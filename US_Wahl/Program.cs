using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using US_Wahl.Model;
using US_Wahl.View;
using US_Wahl.Controller;

namespace US_Wahl
{
    class Program
    {
        private static object anzahl = 500;
        internal static List<Person> wahlvolk = ModelGenerator.ZeigeWahlvolk ();

        static void Main(string[] args)
        {
            Bildschirmausgabe.Menue (); 
            Console.ReadKey();
        }
    }
}
