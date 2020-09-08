using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datentyp_bool_Boolean_Übung
{
    class Program
    {
        static void Main(string[] args)
        {
            int meinAlter = 34;
            int alterMeinerTochter = 4;
            bool resultat;

            // istGleich
            resultat = istGleich(meinAlter, alterMeinerTochter);
            Console.WriteLine("{0} ist Gleich {1}: {2}", meinAlter, alterMeinerTochter, resultat);

            // istUnGleich
            resultat = istUnGleich(meinAlter, alterMeinerTochter);
            Console.WriteLine("{0} ist UnGleich {1}: {2}", meinAlter, alterMeinerTochter, resultat);

            // istGrösser
            resultat = istGrosser(meinAlter, alterMeinerTochter);
            Console.WriteLine("{0} ist Grösser {1}: {2}", meinAlter, alterMeinerTochter, resultat);

            //istGrösserOderGleich
            resultat = istGrosserOderGleich(meinAlter, alterMeinerTochter);
            Console.WriteLine("{0} ist Grösser oder Gleich {1}: {2}", meinAlter, alterMeinerTochter, resultat);

            //istKleiner
            resultat = istKleiner(meinAlter, alterMeinerTochter);
            Console.WriteLine("{0} ist Kleiner {1}: {2}", meinAlter, alterMeinerTochter, resultat);

            //istKleinerOderGleich
            resultat = istKleinerOderGleich(meinAlter, alterMeinerTochter);
            Console.WriteLine("{0} ist Kleiner oder Gleich {1}: {2}", meinAlter, alterMeinerTochter, resultat);

            Console.WriteLine();
            Console.WriteLine("Bitte Return drucken zum beenden");
            Console.ReadLine();
        }
        static bool istGleich(int a, int b)
        {
            return a == b;
        }
        static bool istUnGleich(int a, int b)
        {
            return a != b;
        }
        static bool istGrosser(int a, int b)
        {
            return a > b;
        }
        static bool istGrosserOderGleich(int a, int b)
        {
            return a >= b;
        }
        static bool istKleiner(int a, int b)
        {
            return a < b;
        }
        static bool istKleinerOderGleich(int a, int b)
        {
            return a <= b;
        }
    }
}
