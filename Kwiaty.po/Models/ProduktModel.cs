using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kwiaty.po.Models
{
    public class ProduktModel
    {
        
        public double Cena { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }


        public ProduktModel(double cena, string nazwa, string opis)
        {
            Cena = cena;
            Nazwa = nazwa;
            Opis = opis;
        }

        
    }
}
