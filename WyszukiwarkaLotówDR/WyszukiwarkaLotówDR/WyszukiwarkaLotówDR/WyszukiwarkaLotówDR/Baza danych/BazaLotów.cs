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
            new Lot(1,DateTime.Now.AddDays(1),DateTime.Now.AddDays(4),"Wrocław","Istambuł","WRO","IST",459.99,150),
            new Lot(2,DateTime.Now.AddDays(-1),DateTime.Now.AddDays(1),"Kalisz","Istambuł","WRO","IST",451.99,150),
            new Lot(3,DateTime.Now.AddDays(-1),DateTime.Now.AddDays(1),"Szczecin","Barcelona","WRO","IST",452.99,150),
            new Lot(4,DateTime.Now,DateTime.Now.AddDays(1),"Wrocław","Barcelona","WRO","IST",453.99,150),
            new Lot(5,DateTime.Now,DateTime.Now.AddDays(1),"Kalisz","Barcelona","WRO","IST",453.99,150),
            new Lot(6,DateTime.Now,DateTime.Now.AddDays(1),"Szczecin","Barcelona","WRO","IST",453.99,150)
        };

        public void addLot(Lot lot)
        {
            int idx = listaLotow.Max(l => l.idLotu) + 1;
            lot.idLotu = idx;
            listaLotow.Add(lot);
        }

        public void deleteLot(int id)
        {
            //int idx = listaLotow.FindIndex(l => l.idLotu == id);

            //Console.WriteLine(listaLotow.Select(l => l).ToList().ToString());
            //listaLotow.RemoveAt(idx);
            //Console.WriteLine(listaLotow.Select(l => l).ToList().ToString());
            Console.WriteLine(id);
            int idx = 0;
            bool ok = false;
            for(int i = 0; i < listaLotow.Count; i++)
            {
                if (listaLotow[i].idLotu == id)
                {
                    ok = true;
                    idx = i;
                }
            }
            Console.WriteLine(idx);
            if (ok) listaLotow.RemoveAt(idx);

        }

        public Lot getLot(int id)
        {
            int idx = listaLotow.FindIndex(l => l.idLotu == id);
            return listaLotow.ElementAt(idx);
        }

        public List<Lot> getLoty()
        {
            return listaLotow;
        }

        public void updateLot(Lot lot)
        {
            int idx = listaLotow.FindIndex(l => l.idLotu == lot.idLotu);
            if (idx >= 0)
            {
                listaLotow.ElementAt(idx).miejscePrzylotu = lot.miejscePrzylotu;
                listaLotow.ElementAt(idx).miejsceWylotu = lot.miejsceWylotu;
                listaLotow.ElementAt(idx).iloscMiejsc = lot.iloscMiejsc;
                listaLotow.ElementAt(idx).czasPrzylotu = lot.czasPrzylotu;
                listaLotow.ElementAt(idx).czasWylotu = lot.czasWylotu;
                listaLotow.ElementAt(idx).kodLotniskaPrzylotu = lot.kodLotniskaPrzylotu;
                listaLotow.ElementAt(idx).kodLotniskaWylotu = lot.kodLotniskaWylotu;
                listaLotow.ElementAt(idx).cenaBiletu = lot.cenaBiletu;
            }
        }
    }
}
