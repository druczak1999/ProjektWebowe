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
        public ActionResult Index()
        {
            return View(_baza.getLoty());
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
