using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fröhliche_Zahlen;
using NUnit.Framework;


namespace Fröhliche_Test_Zahlen
{
    public class Test
    {
        [Test, Category("Testigertest")]
        public void Zahl_froh()//?
        {
            string Testiger_Test = DER_ZERSETZER.froh_or_no("19");
            Assert.AreEqual("froh :D", Testiger_Test);
        }
        [Test, Category("Testigerertest")]
        public void Zahl_nicht_so_froh()
        {
            string Testigerer_Test = DER_ZERSETZER.froh_or_no("5");
            Assert.AreEqual("traurig :(", Testigerer_Test);
        }
    }
}