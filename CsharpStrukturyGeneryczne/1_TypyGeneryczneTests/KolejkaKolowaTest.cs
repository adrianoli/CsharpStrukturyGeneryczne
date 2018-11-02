using System;
using _1_TyptyGeneryczne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _1_TypyGeneryczneTests
{
    [TestClass]
    public class KolejkaKolowaTest
    {
        [TestMethod]
        public void NowaKolejkaJestPusta()
        {
            var nowaKolejka = new KolejkaKolowa<double>();
            Assert.IsTrue(nowaKolejka.JestPusty);
        }

        [TestMethod]
        public void KolejkaTrzyElementowaJestPelnaPoTrzechZapisach()
        {
            var nowaKolejka = new KolejkaKolowa<double>(pojemnosc: 3);
            nowaKolejka.Zapisz(3.4);
            nowaKolejka.Zapisz(8.2);
            nowaKolejka.Zapisz(7);

            Assert.IsTrue(nowaKolejka.JestPelny);
        }

        [TestMethod]
        public void PierwszyWchodziPierwszyWychodzi()
        {
            var nowaKolejka = new KolejkaKolowa<double>(pojemnosc: 3);
            var wartosc1 = 3.5;
            var wartosc2 = 4.5;

            nowaKolejka.Zapisz(wartosc1);
            nowaKolejka.Zapisz(wartosc2);

            Assert.AreEqual(wartosc1, nowaKolejka.Czytaj());
            Assert.AreEqual(wartosc2, nowaKolejka.Czytaj());
            Assert.IsTrue(nowaKolejka.JestPusty);
        }

        [TestMethod]
        public void NadpisujeGdyJestWiekszaNizPojemnosc()
        {
            var nowaKolejka = new KolejkaKolowa<double>(pojemnosc: 3);
            var wartosci = new[] { 1.2, 2.4, 4.2, 5.3, 5.6, 8.3 };

            foreach(var wartosc in wartosci)
            {
                nowaKolejka.Zapisz(wartosc);
            }

            Assert.IsTrue(nowaKolejka.JestPelny);
            Assert.AreEqual(wartosci[3], nowaKolejka.Czytaj());
            Assert.AreEqual(wartosci[4], nowaKolejka.Czytaj());
            Assert.AreEqual(wartosci[5], nowaKolejka.Czytaj());
            Assert.IsTrue(nowaKolejka.JestPusty);
        }
    }
}
