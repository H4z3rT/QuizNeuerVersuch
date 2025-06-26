using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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

    }
}
