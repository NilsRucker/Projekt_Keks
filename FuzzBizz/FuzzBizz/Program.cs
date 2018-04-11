using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzBizz
{
    class Program
    {
        static void Main(string[] args)
        {
            var dividend = 25;
            var divisor = 5;
            var Fizz = dividend % divisor == 0;
            string fuzz = "";
            if (Fizz == true)
            {
                fuzz = "Fizz";
            }
//TRENLINIE-------------------------------------------
            Dictionary<string, string> CreativeName =
                new Dictionary<string, string>();
            CreativeName.Add(fuzz, "Fizz");

            Console.WriteLine("Geben sie eine Zahl ein");
            int untergrenze = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geben sie eine weitere Zahl ein");
            int obergrenze = Convert.ToInt32(Console.ReadLine());
            
            var zahlen = new List<int>();
            for (int zahl = untergrenze; zahl <= obergrenze; zahl++)
            {
                zahlen.Add(zahl);
            }

            zahlen.ForEach(i => Console.Write("{0}\t", i));


            Console.WriteLine("Enter zum Schließen!");
            Console.ReadLine();

        }
    }

  
        }
    



