using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kwiaty.po.Models
{
    public class KlientModel
    {
        public string Email { get; set; }
        public ZamowienieModel Koszyk { get; set; }
        List<ZamowienieModel> Zamowienia { get; set; }

        public KlientModel()
        {
            Email = "example@ex.com";
            Koszyk = new ZamowienieModel();
        }

    }
}
