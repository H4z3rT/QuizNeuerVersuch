using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Quiz
{
    public partial class Form3 : Form
    {
        private Datenbank db = new Datenbank();
        private Benutzer aktuellerBenutzer;
        private string spielmodus;
        private string region;
        private List<QuizFrage> fragen;
        private int aktuelleFrage = 0;
        private int aktuellerScore = 0;
        private List<string> aktuelleFlaggenAntworten;
        private string flaggenPfad = @"C:\Flaggen\";
        public Form3(Benutzer benutzer, string spielmodus, string region)
        {
            InitializeComponent();
            aktuellerBenutzer = benutzer;
            this.spielmodus = spielmodus;
            this.region = region;
            ladeQuiz();
        }

        public Form3()
        {
            InitializeComponent();
        }


        private void ladeQuiz()
        {
            buttonPruefen.Click += buttonPruefen_Click;
            buttonBeenden.Click += buttonBeenden_Click;

            fragen = db.getQuizFragen(spielmodus, region, 10);

            if (fragen.Count == 0)
            {
                MessageBox.Show("Keine fragen gefunden!");
                this.Close();
                return;
            }

            //score anzeigen
            updateScoreAnzeige();
            //erste frage anzeigen
            zeigeFrage();
        }



        private void zeigeFrage()
        {
            //radioButtons deaktivieren
            radioButtonA.Checked = false;
            radioButtonB.Checked = false;
            radioButtonC.Checked = false;
            radioButtonD.Checked = false;

            //radioButtons sollen nicht autmatisch ausgewaehlt werden
            radioButtonA.AutoCheck = true;
            radioButtonB.AutoCheck = true;
            radioButtonC.AutoCheck = true;
            radioButtonD.AutoCheck = true;



            if (aktuelleFrage >= fragen.Count)
            {
                beendeQuiz();
                return;
            }

            QuizFrage frage = fragen[aktuelleFrage];

            //frage in labelFrage anzeigen
            labelFrage.Text = frage.Fragetext;

            //flagge anzeigen wenn spielmodus flagge beinhaltet
            if (spielmodus.StartsWith("Flagge_"))
            {
                string flaggenDatei = flaggenPfad + frage.RichtigeAntwort + ".png";
                if (File.Exists(flaggenDatei))
                {
                    pictureBoxFrage.Image = Image.FromFile(flaggenDatei);
                    pictureBoxFrage.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxFrage.Visible = true;
                }
                else 
                {
                    pictureBoxFrage.Visible = false;  
                }
            }
            else
            {
                pictureBoxFrage.Visible = false;
            }

            //antworten erstellen und anzeigen
            List<string> antworten = new List<string>();
            antworten.Add(frage.RichtigeAntwort);
            antworten.Add(frage.FalscheAntwort1);
            antworten.Add(frage.FalscheAntwort2);
            antworten.Add(frage.FalscheAntwort3);

            //antworten in random reihenfolge bringen
            Random rnd = new Random();
            antworten = antworten.OrderBy(x => rnd.Next()).ToList();

            //pruefen ob flaggen als antwort angezeigt werden muesssen
            if (spielmodus.EndsWith("_zu_Flagge"))
            {
                zeigeFlaggenAntworten(antworten);
            }
            else
            {
                zeigeTextAntworten(antworten);
            }
        }



        private void zeigeTextAntworten(List<string> antworten)
        {
            //pictureBoxes ausblenden
            pictureBoxAntwortA.Visible = false;
            pictureBoxAntwortB.Visible = false;
            pictureBoxAntwortC.Visible = false;
            pictureBoxAntwortD.Visible = false;

            //text labels anzeigen
            labelAntwortA.Text = antworten[0];
            labelAntwortB.Text = antworten[1];
            labelAntwortC.Text = antworten[2];
            labelAntwortD.Text = antworten[3];

            labelAntwortA.Visible = true;
            labelAntwortB.Visible = true;
            labelAntwortC.Visible = true;
            labelAntwortD.Visible = true;
        }



        private void zeigeFlaggenAntworten(List<string> antworten)
        {
            //text labels deaktivieren
            labelAntwortA.Visible = false;
            labelAntwortB.Visible = false;
            labelAntwortC.Visible = false;
            labelAntwortD.Visible = false;

            //flaggen fuer antworten laden
            aktuelleFlaggenAntworten = new List<string>(antworten);

            //flaggen laden und in pictureBoxes anzeigen
            ladeFlaggeInPictureBox(antworten[0], pictureBoxAntwortA);
            ladeFlaggeInPictureBox(antworten[1], pictureBoxAntwortB);
            ladeFlaggeInPictureBox(antworten[2], pictureBoxAntwortC);
            ladeFlaggeInPictureBox(antworten[3], pictureBoxAntwortD);

            //pictureBoxes sichtbar machen
            pictureBoxAntwortA.Visible = true;
            pictureBoxAntwortB.Visible = true;
            pictureBoxAntwortC.Visible = true;
            pictureBoxAntwortD.Visible = true;

        }

        private void ladeFlaggeInPictureBox(string landName, PictureBox pictureBox)
        {
            string flaggenDatei = flaggenPfad + landName + ".png";

            if (File.Exists(flaggenDatei))
            {
                pictureBox.Image = Image.FromFile(flaggenDatei);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                //wenn flagge nicht gefunden wurde
                pictureBox.Image = null;
            }
        }



        private void buttonPruefen_Click(object sender, EventArgs e)
        {
            //pruefen welche Antwort ausgewaehlt wurde
            string gewaehlteAntwort = "";

            if (radioButtonA.Checked)
                gewaehlteAntwort = "A";
            else if (radioButtonB.Checked)
                gewaehlteAntwort = "B";
            else if (radioButtonC.Checked)
                gewaehlteAntwort = "C";
            else if (radioButtonD.Checked)
                gewaehlteAntwort = "D";
            else
            {
                MessageBox.Show("Bitte Antwort auswaehlen!");
                return;
                
            }

            //richtige antwort bestimmen
            QuizFrage frage = fragen[aktuelleFrage];
            bool richtig = false;

            if (spielmodus.EndsWith("_zu_Flagge"))
            {
                //pruefe wenn antwort = flaggen 
                int gewaehlterIndex = getSelectedIndex(gewaehlteAntwort);
                if (gewaehlterIndex >= 0 && gewaehlterIndex < aktuelleFlaggenAntworten.Count)
                {
                    string gewaehlterLandname = aktuelleFlaggenAntworten[gewaehlterIndex];
                    richtig = gewaehlterLandname == frage.RichtigeAntwort;
                }
            }
            else
            {
                //pruefe text antworten
                string gewaehlterText = "";
                switch (gewaehlteAntwort)
                {
                    case "A": gewaehlterText = labelAntwortA.Text; break;
                    case "B": gewaehlterText = labelAntwortB.Text; break;
                    case "C": gewaehlterText = labelAntwortC.Text; break;
                    case "D": gewaehlterText = labelAntwortD.Text; break;
                }
                richtig = gewaehlterText == frage.RichtigeAntwort;
            }

            //korrekt oder falsch anzeigen
            if (richtig)
            {
                MessageBox.Show("Korrekt!");
                aktuellerScore++;
            }
            else
            {
                MessageBox.Show("Falsch! Die richtige Antwort ist: " + frage.RichtigeAntwort);
            }
            radioButtonA.Checked = false;
            radioButtonB.Checked = false;
            radioButtonC.Checked = false;
            radioButtonD.Checked = false;

            //zur naechsten frage
            aktuelleFrage++;
            updateScoreAnzeige();
            zeigeFrage();
        }

        


        private int getSelectedIndex(string auswahl)
        {
            switch (auswahl)
            {
                case "A": return 0;
                case "B": return 1;
                case "C": return 2;
                case "D": return 3;
                default: return -1;
            }
        }

        

        //score anzeige aktualisieren
        private void updateScoreAnzeige()
        {
            labelScore.Text = "Score: " + aktuellerScore + "/10";
        }


        //quiz beenden
        private void buttonBeenden_Click(object sender, EventArgs e)
        {
            beendeQuiz();
        }


        private void beendeQuiz()
        {
            //personal highscore abrufen
            int alterHighscore = db.getPersonalHighscore(aktuellerBenutzer.ID);
            int neuerHighscore = Math.Max(alterHighscore, aktuellerScore);

            //quizergebnis speichern
            db.saveQuizScore(aktuellerBenutzer.ID, aktuellerScore, neuerHighscore);

            //ergebnis anzeigen
            string ergebnisText = "Quiz beendet!\n\n";
            ergebnisText += "Ihr Score: " + aktuellerScore + " von " + fragen.Count + " Punkten\n";

            if (aktuellerScore > alterHighscore)
            {
                ergebnisText += "Neuer persönlicher Highscore!\n\n";
            }
            else
            {
                ergebnisText += "Persönlicher Highscore: " + neuerHighscore + " Punkte\n\n";
            }

            //top 10 highscores anzeigen
            List<string> top10 = db.getTopHighscores();
            ergebnisText += "Top 10 Highscores:\n";
            foreach (string eintrag in top10)
            {
                ergebnisText += eintrag + "\n";
            }

            MessageBox.Show(ergebnisText, "Quiz-Ergebnis");

            //form3 schliessen udn form 2 oeffnen
            Form2 form2 = new Form2(aktuellerBenutzer);
            form2.Show();
            this.Close();
        }

    }
    
}
