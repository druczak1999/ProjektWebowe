using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WyszukiwarkaLotówDR.Data;
using WyszukiwarkaLotówDR.Models;

namespace WyszukiwarkaLotówDR.Controllers
{
    [Authorize]
    public class LotModelsController : Controller
    {
        private readonly MyDbContext _context;

        public LotModelsController(MyDbContext context)
        {
            _context = context;
        }

        // GET: LotModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.LotyModel.ToListAsync());
        }

        // GET: LotModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lotModel = await _context.LotyModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lotModel == null)
            {
                return NotFound();
            }

            return View(lotModel);
        }

        // GET: LotModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LotModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Przewoznik,czasWylotu,czasPrzylotu,miejsceWylotu,miejscePrzylotu,kodLotniskaWylotu,kodLotniskaPrzylotu,cenaBiletu,iloscMiejsc,Obraz")] LotModel lotModel)
        {
            if (ModelState.IsValid)
            {
                lotModel.Obraz = lotModel.Przewoznik + ".png";
                _context.Add(lotModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lotModel);
        }

        // GET: LotModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lotModel = await _context.LotyModel.FindAsync(id);
            if (lotModel == null)
            {
                return NotFound();
            }
            return View(lotModel);
        }

        // POST: LotModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Przewoznik,czasWylotu,czasPrzylotu,miejsceWylotu,miejscePrzylotu,kodLotniskaWylotu,kodLotniskaPrzylotu,cenaBiletu,iloscMiejsc,Obraz")] LotModel lotModel)
        {
            if (id != lotModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    lotModel.Obraz = lotModel.Przewoznik + ".png";
                    _context.Update(lotModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LotModelExists(lotModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(lotModel);
        }

        // GET: LotModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lotModel = await _context.LotyModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lotModel == null)
            {
                return NotFound();
            }

            return View(lotModel);
        }

        // POST: LotModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lotModel = await _context.LotyModel.FindAsync(id);
            _context.LotyModel.Remove(lotModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LotModelExists(int id)
        {
            return _context.LotyModel.Any(e => e.Id == id);
        }
    }
}
