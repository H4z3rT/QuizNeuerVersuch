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
        public string Fragetext { get; set; }
        public string RichtigeAntwort { get; set; }
        public string FalscheAntwort1 { get; set; }
        public string FalscheAntwort2 { get; set; }
        public string FalscheAntwort3 { get; set; }
        public string Spielmodus { get; set; }
        public string Region { get; set; }
        public byte[] Flagge { get; set; }

        public QuizFrage(int id, string fragetext, string richtigeAntwort, string falscheAntwort1,
                        string falscheAntwort2, string falscheAntwort3, string spielmodus,
                        string region, byte[] flagge = null)
        {
            ID = id;
            Fragetext = fragetext;
            RichtigeAntwort = richtigeAntwort;
            FalscheAntwort1 = falscheAntwort1;
            FalscheAntwort2 = falscheAntwort2;
            FalscheAntwort3 = falscheAntwort3;
            Spielmodus = spielmodus;
            Region = region;
            Flagge = flagge;
        }
    }
}
