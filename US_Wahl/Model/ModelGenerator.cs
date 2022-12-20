using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace US_Wahl.Model

{
    static class ModelGenerator
    {
        private static Random zfG = new Random();

        static List<Person> wahlvolk = new List<Person>();
        static string[] nachnamen = new string[1000];
        static List<string> jungenVornamen = new List<string>();
        static List<string> maedchenVornamen = new List<string>();


        static ModelGenerator()
        {
            LeseDaten();
            GenerateValues(100);
        }

        private static void LeseDaten()
        {
            using (StreamReader sr = new StreamReader("nachnamen.txt", Encoding.Default))
            {
                for (int i = 0; i < nachnamen.Length; i++)
                {
                    nachnamen[i] = sr.ReadLine();
                }
                
            }

            using (StreamReader sr = new StreamReader("jungennamen.txt", Encoding.Default))
            {
                string line;

                while ( (line = sr.ReadLine()) != null)
                {
                    jungenVornamen.Add(sr.ReadLine());
                }
            }

            using (StreamReader sr = new StreamReader("maedchennamen.txt", Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    maedchenVornamen.Add(sr.ReadLine());
                }
            }
        }



        private static void AddPerson(int id, string vorname, string nachname, string plz, Geschlecht geschlecht, Alter alter, Schicht schicht, Zugehoerigkeit zugehoerigkeit, Beeinflussbarkeit beeinflussbarkeit)
        {
            Person person = new Person();
            person.Id = id;
            person.Vorname = vorname;
            person.Nachname = nachname;
            person.PLZ = plz;
            person.Geschlecht = geschlecht;
            person.Alter = alter;
            person.Schicht = schicht;
            person.Zugehoerigkeit = zugehoerigkeit;
            person.Beeinflussbar = beeinflussbarkeit;
            wahlvolk.Add(person);
        }


        private static void GenerateValues(int anzahl)
        {
            int id;
            string vorname;
            string nachname;
            string plz;
            Geschlecht geschlecht;
            Alter alter;
            Schicht schicht;
            Zugehoerigkeit zugehoerigkeit;
            Beeinflussbarkeit beeinflussbar;
            int zufallszahl;

            for (int i = 0; i < anzahl; i++)
            {
                id = zfG.Next(1, anzahl+1);

                geschlecht = (Geschlecht)zfG.Next(0, 2);
                if (geschlecht == Geschlecht.MAENNLICH)
                {
                    zufallszahl = zfG.Next(0, jungenVornamen.Count);
                    vorname = jungenVornamen.ElementAt(zufallszahl);
                } else
                {
                    zufallszahl = zfG.Next(0, maedchenVornamen.Count);
                    vorname = maedchenVornamen.ElementAt(zufallszahl);
                }

                nachname = nachnamen[zfG.Next(0, nachnamen.Length)];
                plz = zfG.Next(10000, 100000).ToString();
                
                alter = (Alter) zfG.Next(18, 96);
                schicht = (Schicht) zfG.Next(0, 4);
                zugehoerigkeit = (Zugehoerigkeit) zfG.Next(0, 2);
                beeinflussbar = (Beeinflussbarkeit) zfG.Next(0, 3);

                AddPerson(id, vorname, nachname, plz, geschlecht, alter, schicht, zugehoerigkeit, beeinflussbar);
            }
        }

        public static List<Person> ZeigeWahlvolk()
        {
            return wahlvolk;
        }       
    }
}
