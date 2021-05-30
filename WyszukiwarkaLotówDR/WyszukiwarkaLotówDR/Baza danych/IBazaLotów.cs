using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WyszukiwarkaLotówDR.Loty;
using WyszukiwarkaLotówDR.Models;

namespace WyszukiwarkaLotówDR.Baza_danych
{
    public interface IBazaLotów
    {
        public LotModel getLot(int id);
        public List<LotModel> getLoty();
        public void addLot(LotModel lot);
        public void deleteLot(int id);
        public void updateLot(LotModel lot);
    }
}
