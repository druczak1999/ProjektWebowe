using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WyszukiwarkaLotówDR.Baza_danych
{
    public class BazaPlatnosci : IBazaPlatnosci
    {
        private List<Platnosci> listaplatnosci = new List<Platnosci>()
        {
            new Platnosci("visa.png","Płatność kartą"),
            new Platnosci("blik.png","Blik"),
            new Platnosci("przelew.png","Przelew tradycyjny"),
            new Platnosci("payu.png","Przelew szybki")
        };
        public Platnosci GetPlatnosc(int id)
        {
            if (id < listaplatnosci.Count) return listaplatnosci.ElementAt(id);
            else return null;
        }

        public List<Platnosci> GetPlatnosci()
        {
            return listaplatnosci;
        }
    }
    public class Platnosci
    {
        public string Obraz { get; set; }
        public string Nazwa { get; set; }
        public Platnosci(string obraz, string nazwa)
        {
            this.Obraz = obraz;
            this.Nazwa = nazwa;
        }
    }
}
