using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WyszukiwarkaLotówDR.Baza_danych
{
    public interface IBazaPlatnosci
    {
        public Platnosci GetPlatnosc(int id);
        public List<Platnosci> GetPlatnosci();
    }
}
