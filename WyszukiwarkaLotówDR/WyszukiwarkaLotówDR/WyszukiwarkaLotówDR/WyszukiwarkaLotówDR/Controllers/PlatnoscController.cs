using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WyszukiwarkaLotówDR.Baza_danych;

namespace WyszukiwarkaLotówDR.Controllers
{

    public class PlatnoscController : Controller
    {
        private IBazaPlatnosci _baza;
        private static string nazwaPlatnosci = "Przelew tradycyjny";
        public string NazwaPlatnosci { get { return nazwaPlatnosci; } }
        // GET: PlatnoscController
        public PlatnoscController(IBazaPlatnosci baza)
        {
            this._baza = baza;
        }
        public ActionResult Index(string nazwa)
        {
            ViewData["nazwa"] = nazwa;
            if (!String.IsNullOrEmpty(nazwa)) nazwaPlatnosci = nazwa;
            return View(_baza.GetPlatnosci());
        }

        // GET: PlatnoscController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PlatnoscController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PlatnoscController/Create
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

        // GET: PlatnoscController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PlatnoscController/Edit/5
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

        // GET: PlatnoscController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PlatnoscController/Delete/5
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
