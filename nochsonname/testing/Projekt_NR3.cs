using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nochsonname;
using NUnit.Framework;

namespace testing
{
    [TestFixture]
    public class Projekt_NR3
    {
        [Test, Category ("Akzeptanztest")]
        public void Zahlen_zwischen_Untergrenze_Obergrenze()
        {
            var ergebnis = Projekt_NR.Start_Zahlen_testen(3, 5);
            Assert.AreEqual(new[] { 3, 4, 5 }, ergebnis.ToArray());
        }
        [Test, Category ("Gerüsttest")]
        public void Anzahl_Zahlen()
        {
            var ergebnis = Projekt_NR.Zahlen_testen(-1, 44);
            Assert.AreEqual(46, ergebnis.Count());
        }
    }
}
