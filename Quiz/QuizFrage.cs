using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class QuizFrage
    {
        public int ID { get; set; }
        public string FrageText { get; set; }
        public GeoDaten RichtigeAntwort { get; set; }
        public List<GeoDaten> AlleAntworten { get; set; }

        // Konstruktor - erstellt eine neue Frage
        public QuizFrage()
        {
            AlleAntworten = new List<GeoDaten>();
        }
    }
}
