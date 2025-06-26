using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class QuizErgebnis
    {
        public int QuizID { get; set; }
        public int Punktzahl { get; set; }
        public int Highscore { get; set; }
        public int BenutzerID { get; set; }

        public QuizErgebnis(int quizId, int punktzahl, int highscore, int benutzerId)
        {
            QuizID = quizId;
            Punktzahl = punktzahl;
            Highscore = highscore;
            BenutzerID = benutzerId;
        }
    }
}
