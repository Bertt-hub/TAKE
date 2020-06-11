using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PizzeriaApp.Data;
using PizzeriaApp.Models;

namespace PizzeriaApp.Controllers
{
    public class ToppingController : Controller
    {
        private readonly PizzeriaDbContext _context;

        public ToppingController(PizzeriaDbContext context)
        {
            _context = context;
        }

        // GET: Topping
        public async Task<IActionResult> Index()
        {
            return View(await _context.Toppings.ToListAsync());
        }

        // GET: Topping/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var toppingModel = await _context.Toppings
                .FirstOrDefaultAsync(m => m.ToppingId == id);
            if (toppingModel == null)
            {
                return NotFound();
            }

            return View(toppingModel);
        }

        // GET: Topping/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Topping/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ToppingId,ToppingName")] ToppingModel toppingModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(toppingModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(toppingModel);
        }

        // GET: Topping/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var toppingModel = await _context.Toppings.FindAsync(id);
            if (toppingModel == null)
            {
                return NotFound();
            }
            return View(toppingModel);
        }

        // POST: Topping/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ToppingId,ToppingName")] ToppingModel toppingModel)
        {
            if (id != toppingModel.ToppingId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(toppingModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ToppingModelExists(toppingModel.ToppingId))
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
            return View(toppingModel);
        }

        // GET: Topping/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var toppingModel = await _context.Toppings
                .FirstOrDefaultAsync(m => m.ToppingId == id);
            if (toppingModel == null)
            {
                return NotFound();
            }

            return View(toppingModel);
        }

        // POST: Topping/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var toppingModel = await _context.Toppings.FindAsync(id);
            var toppingCount = _context.PizzaToppings.Where(x => x.ToppingId == id).Count();
            if(toppingCount == 0)
            {
                _context.Toppings.Remove(toppingModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            TempData["deleteMessage"] = "Nie można usunąć dodatku! Liczba użyć: " + toppingCount;
            return RedirectToAction(nameof(Index));
        }

        private bool ToppingModelExists(int id)
        {
            return _context.Toppings.Any(e => e.ToppingId == id);
        }
    }
}
