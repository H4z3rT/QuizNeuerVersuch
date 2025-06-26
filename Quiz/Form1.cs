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
        //Login SELECT FROM
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();//Trim entfernt leerzeichen am anfang und ende
            string passwort = textBoxPasswort.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(passwort))
            {
                MessageBox.Show("Bitte Benutznerme und Passwort eingeben!");
            }

            Benutzer b = db.benutzerUeberpruefen(username, passwort);
            if (b != null)
            {
                this.Hide();
                Form2 form2 = new Form2();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Benutzername oder Passwort falsch!");
            }
        }



        //Register INSERT INTO
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
