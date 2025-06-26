using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form2 : Form
    {
        Datenbank db = new Datenbank();
        private Benutzer aktuellerBenutzer;

        public Form2(Benutzer benutzer)
        {
            InitializeComponent();
            aktuellerBenutzer = benutzer;
            ladeForm();

        }


        private void ladeForm()
        {
            //comboBox spielmodus fuellen
            comboBoxSpielmodus.Items.Add("Land_zu_Hauptstadt");
            comboBoxSpielmodus.Items.Add("Hauptstadt_zu_Land");
            comboBoxSpielmodus.Items.Add("Flagge_zu_Land");
            comboBoxSpielmodus.Items.Add("Land_zu_Flagge");
            comboBoxSpielmodus.Items.Add("Hauptstadt_zu_Flagge");
            comboBoxSpielmodus.Items.Add("Flagge_zu_Hauptstadt");
            comboBoxSpielmodus.SelectedIndex = 0; //default: Land_zu_Hauptstadt

            //comboBoxQuizregion fuellen
            comboBoxQuizregion.Items.Add("Weltweit");
            comboBoxQuizregion.Items.Add("Europa");
            comboBoxQuizregion.Items.Add("Asien");
            comboBoxQuizregion.SelectedIndex = 0; //default: Weltweit

            //personelichen highscore laden anzeigen
            if (aktuellerBenutzer != null)
            {
                int highscore = db.getPersonalHighscore(aktuellerBenutzer.ID);
                labelHighscore.Text = "Highscore: " + highscore + " Punkte";
            }

            // Event-Handler für Start-Button hinzufügen
            buttonStart.Click += buttonStart_Click;
        }



        private void buttonStart_Click(object sender, EventArgs e)
        {
            //fehler wenn kein spielmodus oder region ausgewaehlt wurde
            if (comboBoxSpielmodus.SelectedItem == null || comboBoxQuizregion.SelectedItem == null)
            {
                MessageBox.Show("Bitte wählen Sie einen Spielmodus und eine Region aus!");
                return;
            }

            string ausgewaehlterSpielmodus = comboBoxSpielmodus.SelectedItem.ToString();
            string ausgewaehlteRegion = comboBoxQuizregion.SelectedItem.ToString();

            //oeffne form3 
            Form3 form3 = new Form3(aktuellerBenutzer, ausgewaehlterSpielmodus, ausgewaehlteRegion);
            form3.Show();
            this.Hide();
        }

        

        private void buttonAusloggen_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        
    }
}
