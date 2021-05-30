using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WyszukiwarkaLotówDR.Baza_danych;

namespace WyszukiwarkaLotówDR.Controllers
{
    public class ZakupBiletuController : Controller
    {
        private IBazaLotów _bazaLotow;
        private IZakupBiletu _baza;
        private static string bilet = "";
        public string Bilet { get { return bilet; } }
        public ZakupBiletuController(IZakupBiletu baza, IBazaLotów bazaLotow)
        {
            this._baza = baza;
            this._bazaLotow = bazaLotow;
        }
        // GET: ZakupBiletuController
        public ActionResult Index()
        {
            return View(_baza.getZakup(bilet));
        }

        // GET: ZakupBiletuController/Details/5
        public ActionResult Details()
        {

            return View(_baza.getZakup(bilet));
        }
        public ActionResult Dane()
        {
            return View();
        }
        public ActionResult DetailsLot(string login, string idLotu)
        {
            ViewData["Login"] = login;
            ViewData["IdLotu"] = idLotu;
            Console.WriteLine(login);
            Console.WriteLine(idLotu);
            var loty = _baza.getZakupy().Select(z => z);
            if(!String.IsNullOrEmpty(login) && !String.IsNullOrEmpty(idLotu))
            {
                loty.Where(z => z.Klient.Email.Equals(login) && z.Id.Equals(idLotu));
            }
            //if (loty.Count() > 0) { return View(_baza.getZakup(idLotu)); }
            //else return View(loty);
            Console.WriteLine(loty.ToList()[0].Id);
            
            return View(_baza.getZakup(idLotu));
        }

        // GET: ZakupBiletuController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ZakupBiletuController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(int id, Sprzedaz sprzedaz)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    BazaLotówController BL = new BazaLotówController(_bazaLotow);
                    sprzedaz.Lot = BL.Indeks;
                    _baza.addZakup(sprzedaz);
                    bilet = sprzedaz.Id;
                }
                    return RedirectToAction(nameof(Details));
            }
            catch
            {
                return View();
            }
        }

        // GET: ZakupBiletuController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ZakupBiletuController/Edit/5
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

        // GET: ZakupBiletuController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ZakupBiletuController/Delete/5
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
