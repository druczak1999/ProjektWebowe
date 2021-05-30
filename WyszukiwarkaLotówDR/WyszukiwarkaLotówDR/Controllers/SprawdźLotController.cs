using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WyszukiwarkaLotówDR.Baza_danych;

namespace WyszukiwarkaLotówDR.Controllers
{
    public class SprawdźLotController : Controller
    {
        private IZakupBiletu _baza;
        private IBazaLotów _bazaL;
        public SprawdźLotController(IZakupBiletu baza, IBazaLotów bazaL)
        {
            this._baza = baza;
            this._bazaL = bazaL;
        }
        // GET: SprawdźLot
        public ActionResult Index()
        {
            return View();
        }

        // GET: SprawdźLot/Details/5
        public ActionResult Details(string login, string idLotu)
        {
            ViewData["Login"] = login;
            ViewData["IdLotu"] = idLotu;
            Console.WriteLine(login);
            Console.WriteLine(idLotu);
            
            if (!String.IsNullOrEmpty(login) && !String.IsNullOrEmpty(idLotu))
            {
                Console.WriteLine("Jestem w if");
                
                for (int i = 0; i < _baza.getZakupy().Count; i++)
                {
                    Console.WriteLine(_baza.getZakupy()[i].Id);
                    Console.WriteLine(_baza.getZakupy()[i].Klient.Email);
                    if(_baza.getZakupy()[i].Id.Equals(idLotu) && _baza.getZakupy()[i].Klient.Email.Equals(login))
                    {
                        Console.WriteLine("Jestem w 2 if");
                        ViewBag.MiejsceW=_bazaL.getLot(_baza.getZakup(idLotu).Lot).miejsceWylotu+"("+ _bazaL.getLot(_baza.getZakup(idLotu).Lot).kodLotniskaWylotu+") - "+_bazaL.getLot(_baza.getZakup(idLotu).Lot).miejscePrzylotu+" ("+ _bazaL.getLot(_baza.getZakup(idLotu).Lot).kodLotniskaPrzylotu+")";
                        ViewBag.Czas = _bazaL.getLot(_baza.getZakup(idLotu).Lot).czasWylotu + " - " + _bazaL.getLot(_baza.getZakup(idLotu).Lot).czasPrzylotu;
                        return View(_baza.getZakup(idLotu));
                    }
                }
                
            }
            Console.WriteLine("Po if");
            return View();
        }

        // GET: SprawdźLot/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SprawdźLot/Create
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

        // GET: SprawdźLot/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SprawdźLot/Edit/5
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

        // GET: SprawdźLot/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SprawdźLot/Delete/5
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
