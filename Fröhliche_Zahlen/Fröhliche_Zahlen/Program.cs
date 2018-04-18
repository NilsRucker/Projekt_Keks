using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Fröhliche_Zahlen
{
    public class Program
    {
        public static string Eingabe_des_Benutzers()
        {
            Console.Write("Geben sie eine Zahl an: ");
            return Convert.ToString(Console.ReadLine());
        }

        



       

    }
    public class DER_ZERSETZER
    {
       

        public static long[] Zersetze(string Eingabe_des_Benutzers)
        {
            int AnzahlZahlderZahl = Eingabe_des_Benutzers.Length;
            long Eingabe = Convert.ToInt32(Eingabe_des_Benutzers);
            long[] Zersetze = new long[AnzahlZahlderZahl];
            for (int i = 0; i < AnzahlZahlderZahl; i++)
            {
                Zersetze[i] = Convert.ToInt64((Eingabe % Math.Pow(10, i+1) / Math.Pow(10, i)));
            }
            for (int i = 0; i < Zersetze.Count(); i++)

            {

               Eingabe = zahl_zum_rechnen + Convert.ToInt32(Math.Pow(Zahlen_getrent[i], 2));

            }
            return Zersetze
;
        }


        static void Main(string[] args)
        {
            var Eingabe = Program.Eingabe_des_Benutzers();

            //Rechner.Rechne(Convert.ToInt32(Eingabe));
            Console.WriteLine();
            Console.ReadLine();
        }
        
    }
    
   
}
