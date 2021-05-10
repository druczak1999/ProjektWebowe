using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WyszukiwarkaLotówDR.Baza_danych;

namespace WyszukiwarkaLotówDR.Controllers
{
    public class BazaLotówController : Controller
    {
        private IBazaLotów _baza;
        public BazaLotówController(IBazaLotów baza)
        {
            this._baza = baza;
        }
        // GET: BazaLotówController
        public ActionResult Index(string sortOrder, string mWylotu, string mPrzylotu, DateTime data)
        {
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["CenaSortParm"] = sortOrder == "cenaBiletu" ? "cena_desc" : "cenaBiletu";
            ViewData["DataSortParm"] = sortOrder == "czasWylotu" ? "czas_desc" : "czasWylotu";
            ViewData["Wylot"] = mWylotu;
            ViewData["Przylot"] = mPrzylotu;
            ViewData["DataWylotu"] = data;
            var lotycena = _baza.getLoty().Select(l => l);
            if (!String.IsNullOrEmpty(mWylotu) && !String.IsNullOrEmpty(mPrzylotu))
            {
                lotycena = lotycena.Where(s => s.miejsceWylotu.Contains(mWylotu) && s.miejscePrzylotu.Contains(mPrzylotu));
            }
            else if (!String.IsNullOrEmpty(mWylotu) && String.IsNullOrEmpty(mPrzylotu))
            {
                lotycena = lotycena.Where(s => s.miejsceWylotu.Contains(mWylotu));
            }
            else if (!String.IsNullOrEmpty(mPrzylotu) && String.IsNullOrEmpty(mWylotu))
            {
                lotycena = lotycena.Where(s => s.miejscePrzylotu.Contains(mPrzylotu));
            }
            
            else if (!String.IsNullOrEmpty(mWylotu) && lotycena.Count()==0 || !String.IsNullOrEmpty(mPrzylotu) && lotycena.Count()==0)
            {
                ViewBag.Brak = "Niestety nie ma lotu pasującego do twoich kryteriów!";
            }
            if(data.ToString() != "01.01.0001 00:00:00")
            {
                lotycena = lotycena.Where(s => s.czasWylotu >= data && s.czasWylotu < data.AddDays(1));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    lotycena = lotycena.OrderByDescending(s => s.miejsceWylotu);
                    break;
                case "cenaBiletu":
                    lotycena = lotycena.OrderBy(s => s.cenaBiletu);
                    break;
                case "czasWylotu":
                    lotycena = lotycena.OrderBy(s => s.czasWylotu);
                    break;
                case "czas_desc":
                    lotycena = lotycena.OrderByDescending(s => s.czasWylotu);
                    break;
                case "cena_desc":
                    lotycena = lotycena.OrderByDescending(s => s.cenaBiletu);
                    break;
                default:
                    lotycena = lotycena.OrderBy(s => s.miejsceWylotu);
                    break;
            }
                    return View(lotycena);
        }

        // GET: BazaLotówController/Details/5
        public ActionResult Details(int id)
        {
            return View(_baza.getLot(id));
        }

        // GET: BazaLotówController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BazaLotówController/Create
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

        // GET: BazaLotówController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BazaLotówController/Edit/5
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

        // GET: BazaLotówController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BazaLotówController/Delete/5
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
