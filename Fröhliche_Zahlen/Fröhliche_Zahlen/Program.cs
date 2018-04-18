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


        public static string froh_or_no(string Eingabe_des_Benutzers)
        {
            long rechnungszahl = 0;
            do
            {
                int AnzahlZahlderZahl = Eingabe_des_Benutzers.Length;
                long Eingabe = Convert.ToInt32(Eingabe_des_Benutzers);
                long[] Zersetze = new long[AnzahlZahlderZahl];
                
                
                long rechnungszah = 0;
                for (int i = 0; i < AnzahlZahlderZahl; i++)
                {
                    Zersetze[i] = (Eingabe % Convert.ToInt32(Math.Pow(10, Convert.ToDouble(i + 1))) / Convert.ToInt32(Math.Pow(10, Convert.ToDouble(i))));
                }
                for (int i = 0; i < Zersetze.Count(); i++)
                {
                    rechnungszah = rechnungszah + Convert.ToInt64(Math.Pow(Zersetze[i], 2));
                }
                rechnungszahl = rechnungszah;
                Eingabe_des_Benutzers = Convert.ToString(rechnungszah);
            } while (rechnungszahl != 4 && rechnungszahl != 1);
                
            if (rechnungszahl == 4)
            {
                string froh_or_no = "traurig :(";
                return froh_or_no;
            }

            
            else if (rechnungszahl == 1)
            {
                string froh_or_no = "froh :D";
                return froh_or_no;
            }
            else
            {
                return "Nils ist doooooorf";
            }





            //}


        }


        static void Main(string[] args)
        {
            var Eingabe = Program.Eingabe_des_Benutzers();

            //Rechner.Rechne(Convert.ToInt32(Eingabe));
            Console.WriteLine(froh_or_no(Eingabe));
            Console.ReadLine();
        }
        
    }
    
   
}
