using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using US_Wahl.Model;

namespace US_Wahl.Controller {
    static class QueryController {
        
        public static IEnumerable Query_01 (List<Person> people ) {
            var auswahl = people
                .Where ( p => p.Geschlecht == Geschlecht.WEIBLICH )
                .Where ( p => p.Schicht == Schicht.UNTEREMITTELSCHICHT )
                .OrderBy ( p => p.Vorname )
                .Select ( p => new { p.Vorname , p.Nachname , p.Schicht }
                );
            return auswahl;
        }

        public static IEnumerable Query_02 ( List<Person> people ) {
            var auswahl = people
                .Where ( p => p.Geschlecht == Geschlecht.WEIBLICH )
                .Where ( p => p.Schicht == Schicht.OBEREMITTELSCHICHT )
                .Where (p => p.Zugehoerigkeit == Zugehoerigkeit.Demokraten)
                .OrderBy ( p => p.Nachname )
                .Select ( p => new { p.Vorname , p.Nachname , p.Schicht, p.Zugehoerigkeit }
                );
            return auswahl;
        }

        public static IEnumerable Query_03 ( List<Person> people ) {
            var auswahl = people
                .Where ( p => p.Geschlecht == Geschlecht.MAENNLICH )
                .Where ( p => p.Schicht == Schicht.UNTERSCHICHT )
                .Where ( p => p.Zugehoerigkeit == Zugehoerigkeit.Republikaner )
                .OrderBy ( p => p.PLZ )
                .Select ( p => new { p.PLZ, p.Alter , p.Nachname , p.Schicht , p.Zugehoerigkeit }
                );
            return auswahl;
        }
    }
}
