using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class GeoDaten
    {
        public int ID { get; set; }
        public string Kontinent { get; set; }
        public string Land { get; set; }
        public string Hauptstadt { get; set; }
        public string Flagge { get; set; }

        public GeoDaten(int id, string kontinent, string land, string hauptstadt, string flagge)
        {
            ID = id;
            Kontinent = kontinent;
            Land = land;
            Hauptstadt = hauptstadt;
            Flagge = flagge;
        }
    }
}
