using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WyszukiwarkaLotówDR.Models
{
    public enum Przewoznik { Ryanair, EnterAir, LOT, Lufthansa, TurkishAirlines }
    public class LotModel
    {
        [Display(Name = "ID lotu")]
        public int Id { get; set; }

        public Przewoznik Przewoznik { get; set; }
        [Display(Name = "Czas wylotu")]
        public DateTime czasWylotu { get; set; }
        [Display(Name = "Czas przylotu")]
        public DateTime czasPrzylotu { get; set; }
        [Display(Name = "Miejsce wylotu")]
        public string miejsceWylotu { get; set; }
        [Display(Name = "Miejsce przylotu")]
        public string miejscePrzylotu { get; set; }
        [Display(Name = "Kod lotniska wylotu")]
        public string kodLotniskaWylotu { get; set; }
        [Display(Name = "Kod lotniska przylotu")]
        public string kodLotniskaPrzylotu { get; set; }
        [Display(Name = "Cena biletu")]
        public double cenaBiletu { get; set; }
        [Display(Name = "Ilość dostępnych miejsc")]
        public int iloscMiejsc { get; set; }
        public string Obraz { get; set; }
        public LotModel() { }
        public LotModel(int id, Przewoznik przewoznik, DateTime czasW, DateTime czaP, string miejsceW, string miejsceP, string kodLW, string kodLP, double cena, int ilosc, string obraz = "")
        {
            this.Id = id;
            this.Przewoznik = przewoznik;
            this.czasWylotu = czasW;
            this.czasPrzylotu = czaP;
            this.miejsceWylotu = miejsceW;
            this.miejscePrzylotu = miejsceP;
            this.kodLotniskaWylotu = kodLW;
            this.kodLotniskaPrzylotu = kodLP;
            this.cenaBiletu = cena;
            this.iloscMiejsc = ilosc;
            this.Obraz = przewoznik + ".png";

        }
    }
}
