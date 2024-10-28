using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SantiagoConlago_Examen1P.Data;
using SantiagoConlago_Examen1P.Models;

namespace SantiagoConlago_Examen1P.Controllers
{
    public class SantiagoConlago_modelController : Controller
    {
        private readonly SantiagoConlago_Examen1PContext _context;

        public SantiagoConlago_modelController(SantiagoConlago_Examen1PContext context)
        {
            _context = context;
        }

        // GET: SantiagoConlago_model
        public async Task<IActionResult> Index()
        {
            return View(await _context.SantiagoConlago_model.ToListAsync());
        }

        // GET: SantiagoConlago_model/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var santiagoConlago_model = await _context.SantiagoConlago_model
                .FirstOrDefaultAsync(m => m.SantiagoConlago_modelId == id);
            if (santiagoConlago_model == null)
            {
                return NotFound();
            }

            return View(santiagoConlago_model);
        }

        // GET: SantiagoConlago_model/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SantiagoConlago_model/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SantiagoConlago_modelId,SCVideojuego,SCDescription,SCGarantia,SCPrecio")] SantiagoConlago_model santiagoConlago_model)
        {
            if (ModelState.IsValid)
            {
                _context.Add(santiagoConlago_model);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(santiagoConlago_model);
        }

        // GET: SantiagoConlago_model/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var santiagoConlago_model = await _context.SantiagoConlago_model.FindAsync(id);
            if (santiagoConlago_model == null)
            {
                return NotFound();
            }
            return View(santiagoConlago_model);
        }

        // POST: SantiagoConlago_model/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SantiagoConlago_modelId,SCVideojuego,SCDescription,SCGarantia,SCPrecio")] SantiagoConlago_model santiagoConlago_model)
        {
            if (id != santiagoConlago_model.SantiagoConlago_modelId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(santiagoConlago_model);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SantiagoConlago_modelExists(santiagoConlago_model.SantiagoConlago_modelId))
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
            return View(santiagoConlago_model);
        }

        // GET: SantiagoConlago_model/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var santiagoConlago_model = await _context.SantiagoConlago_model
                .FirstOrDefaultAsync(m => m.SantiagoConlago_modelId == id);
            if (santiagoConlago_model == null)
            {
                return NotFound();
            }

            return View(santiagoConlago_model);
        }

        // POST: SantiagoConlago_model/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var santiagoConlago_model = await _context.SantiagoConlago_model.FindAsync(id);
            if (santiagoConlago_model != null)
            {
                _context.SantiagoConlago_model.Remove(santiagoConlago_model);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SantiagoConlago_modelExists(int id)
        {
            return _context.SantiagoConlago_model.Any(e => e.SantiagoConlago_modelId == id);
        }
    }
}
