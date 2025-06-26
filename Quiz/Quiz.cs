using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Quiz
    {
        public int ID { get; set; }
        public int Punkte { get; set; }
        public int BenutzerID { get; set; }
        public List<QuizFrage> Fragen { get; set; }

        public Quiz()
        {
            Punkte = 0;
            Fragen = new List<QuizFrage>();
        }
    }
}
