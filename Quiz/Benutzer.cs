namespace Quiz
{
    public class Benutzer
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Passwort { get; set; }

        
        public Benutzer(int id, string username, string passwort)
        {
            ID = id;
            Username = username;
            Passwort = passwort;
        }
    }
}