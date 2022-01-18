using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebShop;

namespace WebShopTest
{
    [TestClass]
    public class WebShopTests
    {
        Proizvod p;

        [TestMethod]
        public void UkupnaCijenaTest()
        {
            double izmjenaUkupno=0;

            double cijena1 = 999;
            int kolicina1 = 2;
            double cijena2 = 250;
            int kolicina2 = 1;
            double ocekivanaUkupnaCijena = 2248;

            p = new Proizvod("Racunalo", cijena1, "Tehnologija");
            p = new Proizvod("Miš", cijena2, "Tehnologija");

            izmjenaUkupno += p.UkupnaCijena(kolicina1, cijena1);           
            izmjenaUkupno += p.UkupnaCijena(kolicina2, cijena2);

            Assert.AreEqual(ocekivanaUkupnaCijena, izmjenaUkupno);
        }
         

      
    }
}
