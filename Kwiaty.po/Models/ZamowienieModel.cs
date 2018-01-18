﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kwiaty.po.Models
{
    public class ZamowienieModel
    {
        public List<PozycjaZamowieniaModel> PozycjeZamowienia;
        public string AdresDostawy { get; set; }
        public SposobDostawy Dostawa { get; set; }
        public SposobPlatnosci Platnosc { get; set; }
        public StatusZamowienia Status { get; set; }

        public double WartoscZamowienia
        {
            get
            {
                double wartosc = 0;
                foreach (PozycjaZamowieniaModel p in PozycjeZamowienia)
                {
                    wartosc += p.WartoscPozycji;
                }
                return wartosc;
            }
        }
        public enum StatusZamowienia { przyjete, wyslane, doOdbioru, zrealizowane}
        public enum SposobDostawy { wskazanyAdres, odbiorOsobisty}
        public enum SposobPlatnosci { gotowka, karta}
    }
}
