using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WyszukiwarkaLotówDR.Loty;

namespace WyszukiwarkaLotówDR.Baza_danych
{
    public class BazaLotów:IBazaLotów
    {
        List<Lot> listaLotow = new List<Lot>()
        {
            new Lot(1,DateTime.Now,DateTime.Now.AddDays(1),"Wrocław","Istambuł","WRO","IST",459.99,150),
            new Lot(2,DateTime.Now,DateTime.Now.AddDays(1),"Wrocław","Istambuł","WRO","IST",459.99,150)
        };

        public Lot getLot(int id)
        {
            if (id < listaLotow.Count && id >= 0)
            {
                return listaLotow.FirstOrDefault(a => a.idLotu == id);
            }
            else return null;
        }

        public List<Lot> getLoty()
        {
            return listaLotow;
        }
    }
}
