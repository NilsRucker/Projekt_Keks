using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fröhliche_Zahlen
{
    public class DER_ffZERSETZER
    {
       public static long[] Zersetze(int Eingabe_des_Benutzers)
        {
            long[] Zahlenzersetzung = new long[10];
            
            Zahlenzersetzung[0] = Eingabe_des_Benutzers % 10;
            Zahlenzersetzung[1] = Eingabe_des_Benutzers % 100 / 10;
            Zahlenzersetzung[2] = Eingabe_des_Benutzers % 1000 / 100;
            Zahlenzersetzung[3] = Eingabe_des_Benutzers % 10000 / 1000;
            Zahlenzersetzung[4] = Eingabe_des_Benutzers % 100000 / 10000;
            Zahlenzersetzung[5] = Eingabe_des_Benutzers % 1000000 / 100000;
            Zahlenzersetzung[6] = Eingabe_des_Benutzers % 10000000 / 1000000;
            Zahlenzersetzung[7] = Eingabe_des_Benutzers % 100000000 / 10000000;
            Zahlenzersetzung[8] = Eingabe_des_Benutzers % 1000000000 / 100000000;
            Zahlenzersetzung[9] = Eingabe_des_Benutzers % 10000000000 / 1000000000;
            Zahlenzersetzung[10]= Eingabe_des_Benutzers % 100000000000 / 10000000000;

            return Zahlenzersetzung;
        }
    }
}
