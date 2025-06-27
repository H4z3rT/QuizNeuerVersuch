namespace Quiz
{
    public partial class Form1 : Form
    {
        Datenbank db = new Datenbank();
        private Benutzer aktuellerBenutzer;
        public Form1()
        {
            InitializeComponent();
        }
        //benutzer einloggen wenn benutzer in DB vorhanden ist
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();//Trim entfernt leerzeichen am anfang und ende
            string passwort = textBoxPasswort.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(passwort))
            {
                MessageBox.Show("Bitte Benutznerme und Passwort eingeben!");
            }

            Benutzer benutzer = db.benutzerUeberpruefen(username, passwort);
            if (benutzer != null)
            {
                this.Hide();
                Form2 form2 = new Form2(benutzer);
                form2.Show();
            }
            else
            {
                MessageBox.Show("Benutzername oder Passwort falsch!");
            }
        }



        //benutzer register wenn nicht bereits in DB vorhanden
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();//Trim entfernt Leerzeichen am Anfang und Ende
            string passwort = textBoxPasswort.Text.Trim();
            //ueberpruefen ob username und passwort eingegeben wurden oder nicht
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(passwort))
            {
                MessageBox.Show("Bitte Benutzname und Passwort eingeben!");
                return;
            }

            //benutzer bereits in db vorhanden?
            if (db.benutzerUeberpruefen(username, passwort) != null)
            {
                MessageBox.Show("Benutzer bereits registriert!");
            }
            else
            {
                Benutzer neuerBenutzer = new Benutzer(-1, username, passwort);
                db.benutzerRegister(neuerBenutzer);
                MessageBox.Show("Benutzer erfolgreich registriert");

            }
        }


    }
}
