using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop
{
    public class Proizvod
    {
        public string Opis { get; set; }
        public double Cijena { get; set; }
        public int Kolicina { get; set; }

        public string Kategorija { get; set; }

        public Proizvod(string opis,double cijena,string kategorija)
        {
            Opis = opis;
            Cijena = cijena;
            Kategorija = kategorija;
        }

        public double UkupnaCijena(int k,double c)
        {
            double Ukupno = k * c;
            return Ukupno;
        }


    }
}
