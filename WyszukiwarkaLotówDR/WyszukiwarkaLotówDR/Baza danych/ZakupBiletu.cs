using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WyszukiwarkaLotówDR.Loty;

namespace WyszukiwarkaLotówDR.Baza_danych
{
    public class ZakupBiletu: IZakupBiletu
    {
        private List<Sprzedaz> listasprzedanych = new List<Sprzedaz>()
        {
            new Sprzedaz(new Klient("12345678910", "Ola", "Druczak", "DOK123", "Olciaa1999@gmail.com", 123456789), 1, 1, "1234556")
        };

        public void addZakup(Sprzedaz sprzedaz)
        {
            sprzedaz.Id = Guid.NewGuid().ToString();
            listasprzedanych.Add(sprzedaz);
        }

        public Sprzedaz getZakup(string id)
        {
            return listasprzedanych.Find(l => l.Id == id);
        }

        public List<Sprzedaz> getZakupy()
        {
            return listasprzedanych;
        }
    }
    public class Klient
    {
        [Required(ErrorMessage = "Proszę podać PESEL")]
        public string PESEL { get; set; }
        [Required(ErrorMessage = "Proszę podać imię!")]
        public string Imie { get; set; }
        [Required(ErrorMessage = "Proszę podać nazwisko!")]
        public string Nazwisko { get; set; }
        [Required(ErrorMessage = "Proszę podać numer paszportu lub dowodu")]
        public string NumerDokumentu { get; set; }
        [Required(ErrorMessage = "Proszę podać email")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Niepoprawny format adresu email")]
        [MinLength(5, ErrorMessage = "Za krótki adres email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Proszę podać numer telefonu")]
        [DataType(DataType.PhoneNumber)]
        public int NumerTelefonu { get; set; }
        public Klient()
        {

        }
        public Klient(string pesel, string imie, string nazwisko, string numerdokumentu, string email, int numertelefonu)
        {
            this.PESEL = pesel;
            this.Imie = imie;
            this.Nazwisko = nazwisko;
            this.NumerDokumentu = numerdokumentu;
            this.Email = email;
            this.NumerTelefonu = numertelefonu;
        }
    }
    public class Sprzedaz
    {
        public string Id { get; set; }
        [Required(ErrorMessage = "Proszę podać dane")]
        public Klient Klient { get; set; }
        public int Lot { get; set; }
        [Required(ErrorMessage = "Proszę wybrać ilość biletów")]
        [Range(1,10, ErrorMessage ="Maksymalna ilość biletów to 10, minimalna 1")]
        public int IloscBiletow { get; set; }
        public Sprzedaz()
        {

        }
        public Sprzedaz(Klient klient, int lot, int iloscbiletow, string id = "")
        {
            this.Id = id;
            this.Klient = klient;
            this.Lot = lot;
            this.IloscBiletow = iloscbiletow;
        }
    }
}
