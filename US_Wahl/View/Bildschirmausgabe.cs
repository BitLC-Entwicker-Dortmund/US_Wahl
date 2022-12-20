using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using US_Wahl.Model;
using US_Wahl.Controller;

namespace US_Wahl.View {
    class Bildschirmausgabe {

        public static void Menue() {
            string eingabe;

            Console.WriteLine ("View: Hauptmenue");
            Console.WriteLine ("================");
            Console.WriteLine ("Query 1   - press 1");
            Console.WriteLine ("Query 2   - press 2");
            Console.WriteLine ("Query 3   - press 3");

            Console.Write ("Auswahl: ");
            eingabe = Console.ReadLine ();
            if ( eingabe.Equals( "1" )) {
                AnzeigenCollection(QueryController.Query_01 (US_Wahl.Program.wahlvolk));
            } else
            if ( eingabe.Equals("2") ) {
                AnzeigenCollection ( QueryController.Query_02 ( US_Wahl.Program.wahlvolk ) );
            } else
            if ( eingabe.Equals("3") ) {
                AnzeigenCollection ( QueryController.Query_03 ( US_Wahl.Program.wahlvolk ) );
            }
            else Console.WriteLine ("keine Auswahl");
        }

        public static void AnzeigenCollection ( System.Collections.IEnumerable ie ) {
            foreach ( var item in ie ) {
                Console.WriteLine (item);
            }
        }

        public static void AnzeigenCollection ( List<Person> people ) {
            foreach ( var item in people ) {
                Console.WriteLine ( "id: {0} Vorname: {1} Nachname: {2}, Zugehörigkeit: {3} ",item.Id, item.Vorname, item.Nachname, item.Zugehoerigkeit );
            }
        }

    }
}
