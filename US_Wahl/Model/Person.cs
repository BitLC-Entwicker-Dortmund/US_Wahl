using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace US_Wahl.Model {
    
    class Person {
        public int Id { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string PLZ { get; set; }
        public Geschlecht Geschlecht { get; set; }
        public Alter Alter { get; set; }
        public Schicht Schicht { get; set; }
        public Zugehoerigkeit Zugehoerigkeit { get; set; }
        public Beeinflussbarkeit Beeinflussbar { get; set; }
    }
}
