using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Datenbank
    {
        private MySqlConnection conn;
        private string connstr = "SERVER=localhost;UID='root';PASSWORD='';DATABASE=Quiz";

        public Datenbank()
        {
            conn = new MySqlConnection(connstr);
        }



        //fuer login ueberpruefen ob benutzer bereits in DB vorhanden ist
        public Benutzer benutzerUeberpruefen(string username, string passwort)
        {

            conn.Open();
            Benutzer bn = null;
            try
            {
                //suche benutzer mit uebereinstimmendem username und passwort
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format("SELECT * FROM benutzer " +
                    "WHERE username ='{0}' AND passwort = '{1}';", username, passwort);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    bn = new Benutzer(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2)
                        );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            return bn;
        }



        //Benutzer register falls nicht vorhanden
        public void benutzerRegister(Benutzer b)
        {
            conn.Open();
            try
            {
                //benutzer in datenbank einfuegen (insert)
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format("INSERT INTO benutzer VALUES(NULL, '{0}', '{1}')",
                    b.Username, b.Passwort);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }



        //persoenlichen Highscore des benutzers
        public int getPersonalHighscore(int benutzerID)
        {
            conn.Open();
            int highscore = 0;
            try
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format("SELECT MAX(highscore) FROM quiz WHERE BID = {0}",
                    benutzerID);
                object result = cmd.ExecuteScalar();

                if (result != DBNull.Value && result != null)
                {
                    highscore = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            return highscore;
        }



        //quiz fragen basierend auf spielmodi und region auswahl
        public List<QuizFrage> getQuizFragen(string spielmodus, string region, int anzahl = 10)
        {
            conn.Open();
            List<QuizFrage> fragen = new List<QuizFrage>();
            try
            {
                MySqlCommand cmd = conn.CreateCommand();
                string query = "";

                if (region == "Weltweit")
                {
                    query = string.Format("SELECT g.GeoDatenID, g.kontinent, g.land, g.hauptstadt, g.flagge, " +
                        "f.frageID, f.fragetyp FROM geodaten g " +
                        "JOIN frage f ON g.GeoDatenID = f.GDID " +
                        "WHERE f.fragetyp = '{0}' ORDER BY RAND() LIMIT {1}",
                        spielmodus, anzahl);
                }
                else
                {
                    query = string.Format("SELECT g.GeoDatenID, g.kontinent, g.land, g.hauptstadt, g.flagge, " +
                        "f.frageID, f.fragetyp FROM GeoDaten g " +
                        "JOIN frage f ON g.GeoDatenID = f.GDID " +
                        "WHERE f.fragetyp = '{0}' AND g.kontinent = '{1}' ORDER BY RAND() LIMIT {2}",
                        spielmodus, region, anzahl);
                }
                
                cmd.CommandText = query;
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string fragetext = "";
                    string richtigeAntwort = "";
                    //frage und antwort richtig bestimmen
                    switch (spielmodus)
                    {
                        case "Land_zu_Hauptstadt":
                            fragetext = "Wie heisst die Hauptstadt von " + reader.GetString("land") + "?";
                            richtigeAntwort = reader.GetString("hauptstadt");
                            break;

                        case "Hauptstadt_zu_Land":
                            fragetext = "Zu welchem Land gehoert diese Hauptstadt " + reader.GetString("hauptstadt") + "?";
                            richtigeAntwort = reader.GetString("land");
                            break;

                        case "Flagge_zuLand":
                            fragetext = "Zu welchem Land gehoert diese Flagge?";
                            richtigeAntwort = reader.GetString("land");
                            break;

                        case "Land_zu_Flagge":
                            fragetext = "Welche Flagge gehoert zu " + reader.GetString("land") + "?";
                            richtigeAntwort = reader.GetString("flagge");
                            break;

                        case "Hauptstad_zu_Flagge":
                            fragetext = "Welche Flagge gehoert zur Hauptstadt " + reader.GetString("hauptstadt") + "?";
                            richtigeAntwort = reader.GetString("flagge");
                            break;

                        case "Flagge_zu_Hauptstadt":
                            fragetext = "Welche Hauptstadt gehoert zu dieser Flagge?";
                            richtigeAntwort = reader.GetString("hauptstadt");
                            break;
                    }


                    byte[] flagge = null;
                    if (!reader.IsDBNull("flagge"))
                    { 
                        flagge = (byte[])reader["flagge"];
                    }

                    QuizFrage frage = new QuizFrage(
                        reader.GetInt32("GeoDatenID"),
                        fragetext,
                        richtigeAntwort,
                        "", "", "", //falschen antworten noch hinzufuegen!
                        spielmodus,
                        region,
                        flagge
                        );

                    fragen.Add(frage); 
                }
                reader.Close();

                foreach (QuizFrage frage in fragen)
                {
                    List<string> falscheAntworten = getFalscheAntworten(frage, region);
                    if (falscheAntworten.Count >= 3)
                    {
                        frage.FalscheAntwort1 = falscheAntworten[0];
                        frage.FalscheAntwort2 = falscheAntworten[1];
                        frage.FalscheAntwort3 = falscheAntworten[2];
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
            return fragen;
        }



        //falsche antworten für frage erstellen
        public List<string> getFalscheAntworten(QuizFrage frage, string region)
        {
            List<string> falscheAntworten = new List<string>();
            try
            {
                MySqlCommand cmd = conn.CreateCommand();
                string spalte = "";

                if (frage.Spielmodus.Contains("Hauptstadt"))
                {
                    if (frage.Spielmodus == "Land_zu_Hauptstadt" || frage.Spielmodus == "Flagge_zu_Hauptstadt")
                        spalte = "hauptstadt";
                    else
                        spalte = "land";
                }
                else if (frage.Spielmodus.Contains("Land"))
                {
                    spalte = "land";
                }
                else
                { 
                    spalte = "flagge";
                }

                string query = "";
                if (region == "Weltweit")
                {
                    query = string.Format("SELECT {0} FROM geodaten WHERE {0} != '{1}' ORDER BY RAND() LIMIT 3",
                        spalte, frage.RichtigeAntwort);
                }
                else
                {
                    query = string.Format("SELECT {0} FROM geodaten WHERE {0} != '{1}' AND kontinent = '{2}' ORDER BY RAND() LIMIT 3",
                        spalte, frage.RichtigeAntwort, region);
                }

                cmd.CommandText = query;
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    falscheAntworten.Add(reader.GetString(spalte));
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return falscheAntworten;
        }



        //quiz score speichern
        public void saveQuizScore(int benutzerID, int punktzahl, int highscore)
        {
            conn.Open();
            try
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format("INSERT INTO quiz VALUES(NULL, {0}, {1}, {2})",
                    punktzahl, highscore, benutzerID);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }



        //top 10 highscore aller spieler
        public List<string> getTopHighscores()
        {
            conn.Open();
            List<string> highscores = new List<string>();
            try
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT b.username, MAX(q.highscore) AS max_highscore " +
                    "FROM benutzer b " +
                    "JOIN quiz q ON b.benutzerID = q.BID " +
                    "GROUP BY b.benutzerID " +
                    "ORDER BY max_highscore DESC LIMIT 10";

                MySqlDataReader reader = cmd.ExecuteReader();

                int platz = 1;
                while (reader.Read())
                {
                    string eintrag = string.Format("{0}. '{1}': {2} Punkte",
                        platz, reader.GetString("username"), reader.GetInt32("max_highscore"));

                    highscores.Add(eintrag);
                    platz++;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
            return highscores;
        }



        //flagge als bild laden
        public byte[] getFlagge(int geodatenID)
        {
            conn.Open();
            byte[] flagge = null;
            try
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format("SELECT flagge FROM geodaten WHERE geodatenID = {0}", geodatenID);
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value && result != null)
                {
                    flagge = (byte[])result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
            return flagge;
        }



        //falsche flaggen fuer antworten laden
        public List<byte[]> getFalscheFlaggen(QuizFrage frage, string region)
        {
            conn.Open();
            List<byte[]> falscheFlaggen = new List<byte[]>();
            try
            {
                MySqlCommand cmd = conn.CreateCommand();
                string query = "";

                if (region == "Weltweit")
                {
                    query = string.Format("SELECT flagge FROM geodaten WHERE land != '{0}' AND flagge IS NOT NULL ORDER BY RAND() LIMIT 3",
                                         frage.RichtigeAntwort);
                }
                else
                {
                    query = string.Format("SELECT flagge FROM geodaten WHERE land != '{0}' AND kontinent = '{1}' AND flagge IS NOT NULL ORDER BY RAND() LIMIT 3",
                                         frage.RichtigeAntwort, region);
                }

                cmd.CommandText = query;
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (!reader.IsDBNull("flagge"))
                    {
                        falscheFlaggen.Add((byte[])reader["flagge"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            return falscheFlaggen;
        }
    }
}
