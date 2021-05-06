using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WyszukiwarkaLotówDR.Loty
{
    public class Lot
    {
        public int idLotu { get; set; }
        public DateTime czasWylotu { get; set; }
        public DateTime czasPrzylotu { get; set; }
        public string miejsceWylotu { get; set; }
        public string miejscePrzylotu { get; set; }
        public string kodLotniskaWylotu { get; set; }
        public string kodLotniskaPrzylotu { get; set; }
        public double cenaBiletu { get; set; }
        public int iloscMiejsc { get; set; }

        public Lot(int id, DateTime czasW, DateTime czaP, string miejsceW, string miejsceP, string kodLW, string kodLP, double cena, int ilosc)
        {
            this.idLotu = id;
            this.czasWylotu = czasW;
            this.czasPrzylotu = czaP;
            this.miejsceWylotu = miejsceW;
            this.miejscePrzylotu = miejsceP;
            this.kodLotniskaWylotu = kodLW;
            this.kodLotniskaPrzylotu = kodLP;
            this.cenaBiletu = cena;
            this.iloscMiejsc = ilosc;

        }
    }
}
