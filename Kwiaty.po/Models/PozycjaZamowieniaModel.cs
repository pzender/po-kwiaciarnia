using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kwiaty.po.Models
{
    public class PozycjaZamowieniaModel
    {
        public int IloscSztuk { get; set; }
        ProduktModel Produkt { get; set; }
        public double WartoscPozycji => IloscSztuk * Produkt.Cena;
    }
}
