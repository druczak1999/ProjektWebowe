using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WyszukiwarkaLotówDR.Baza_danych;

namespace WyszukiwarkaLotówDR.Controllers
{
    public class PodsumowanieController : Controller
    {
        private IBazaLotów _bazaLotów;
        private IBazaPlatnosci _bazaPlatnosci;
        private IZakupBiletu _zakupBiletu;

        public PodsumowanieController(IBazaLotów bazaLotów, IBazaPlatnosci bazaPlatnosci, IZakupBiletu zakup)
        {
            this._bazaLotów = bazaLotów;
            this._bazaPlatnosci = bazaPlatnosci;
            this._zakupBiletu = zakup;
        }
        // GET: PodsumowanieController
        public ActionResult Index()
        {
            BazaLotówController bl = new BazaLotówController(_bazaLotów);
            PlatnoscController pl = new PlatnoscController(_bazaPlatnosci);
            ZakupBiletuController zl = new ZakupBiletuController(_zakupBiletu, _bazaLotów);
            ViewBag.Lot = "Skąd dokąd: " + _bazaLotów.getLot(bl.Indeks).miejsceWylotu + " - " + _bazaLotów.getLot(bl.Indeks).miejscePrzylotu;
            ViewBag.Lot2 = "Data wylotu i przylotu: " + _bazaLotów.getLot(bl.Indeks).czasWylotu + " - " + _bazaLotów.getLot(bl.Indeks).czasPrzylotu;
            ViewBag.Lot3 = "Cena biletu: " + _bazaLotów.getLot(bl.Indeks).cenaBiletu;
            ViewBag.Ilosc = "Ilość bieltów na lot: " + _zakupBiletu.getZakup(zl.Bilet).IloscBiletow;
            ViewBag.Klient = "Twój PESEL: " + _zakupBiletu.getZakup(zl.Bilet).Klient.PESEL;
            ViewBag.Klient1 = "Numer towjego dokumentu: " + _zakupBiletu.getZakup(zl.Bilet).Klient.NumerDokumentu;
            ViewBag.Klient2 = "Twoje imie i nazwisko: " + _zakupBiletu.getZakup(zl.Bilet).Klient.Imie + " "+_zakupBiletu.getZakup(zl.Bilet).Klient.Nazwisko;
            ViewBag.Klient3 = "Twój email: " + _zakupBiletu.getZakup(zl.Bilet).Klient.Email + ", twój numer telefonu: " + _zakupBiletu.getZakup(zl.Bilet).Klient.NumerTelefonu+", id twojego lotu: "+_zakupBiletu.getZakup(zl.Bilet).Id;
            ViewBag.Obrazek = _bazaLotów.getLot(bl.Indeks).Obraz;
            int indplat = 0;
            for (int i = 0; i < _bazaPlatnosci.GetPlatnosci().Count; i++)
                if (_bazaPlatnosci.GetPlatnosc(i).Nazwa == pl.NazwaPlatnosci) indplat = i;
            ViewBag.Platnosci1 = _bazaPlatnosci.GetPlatnosc(indplat).Nazwa;
            ViewBag.Suma = _bazaLotów.getLot(bl.Indeks).cenaBiletu * _zakupBiletu.getZakup(zl.Bilet).IloscBiletow;
            return View();
        }

        // GET: PodsumowanieController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PodsumowanieController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PodsumowanieController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PodsumowanieController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PodsumowanieController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PodsumowanieController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PodsumowanieController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
