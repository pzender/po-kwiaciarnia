using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kwiaty.po.Models
{
    public class PozycjaZamowieniaModel
    {
        public int IloscSztuk { get; set; }
        public ProduktModel Produkt { get; set; }
        public double WartoscPozycji => IloscSztuk * Produkt.Cena;

        public PozycjaZamowieniaModel(ProduktModel produkt, int ilosc)
        {
            Produkt = produkt;
            IloscSztuk = ilosc;
        }
    }
}
