using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WyszukiwarkaLotówDR.Baza_danych
{
    public interface IZakupBiletu
    {
        public Sprzedaz getZakup(string id);
        public List<Sprzedaz> getZakupy();
        public void addZakup(Sprzedaz sprzedaz);
    }
}
