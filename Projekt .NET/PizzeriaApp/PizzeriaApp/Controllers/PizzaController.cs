using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PizzeriaApp.Data;
using PizzeriaApp.Models;

namespace PizzeriaApp.Controllers
{
    public class PizzaController : Controller
    {
        private readonly PizzeriaDbContext _context;

        public PizzaController(PizzeriaDbContext context)
        {
            _context = context;
        }

        // GET: Pizza
        public async Task<IActionResult> Index(string searchName)
        {
            AllDataModel allData = new AllDataModel();
            allData.allPizzas = _context.Pizzas.Where(x => x.PizzaName.Contains(searchName) || searchName == null).ToList();
            allData.allToppings = _context.Toppings.ToList();
            allData.allPizzasToppings = _context.PizzaToppings.Include(p => p.Pizza).Include(p => p.Topping).ToList();
            return View(allData);
        }

        // GET: Pizza/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pizzaModel = await _context.Pizzas
                .FirstOrDefaultAsync(m => m.PizzaId == id);
            if (pizzaModel == null)
            {
                return NotFound();
            }

            return View(pizzaModel);
        }

        // GET: Pizza/Create
        public IActionResult Create()
        {
            ViewData["Dough"] = new SelectList(new List<string>() { "cienkie", "grube" });
            return View();
        }

        // POST: Pizza/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PizzaId,PizzaName,PriceSmall,PriceMedium,PriceBig,Dough")] PizzaModel pizzaModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pizzaModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Dough"] = new SelectList(new List<string>() { "cienkie", "grube" });
            return View(pizzaModel);
        }

        // GET: Pizza/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pizzaModel = await _context.Pizzas.FindAsync(id);
            if (pizzaModel == null)
            {
                return NotFound();
            }
            ViewData["Dough"] = new SelectList(new List<string>() { "cienkie", "grube" });
            return View(pizzaModel);
        }


        // POST: Pizza/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PizzaId,PizzaName,PriceSmall,PriceMedium,PriceBig,Dough")] PizzaModel pizzaModel)
        {
            if (id != pizzaModel.PizzaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pizzaModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PizzaModelExists(pizzaModel.PizzaId))
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
            
            return View(pizzaModel);
        }

        // GET: Pizza/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pizzaModel = await _context.Pizzas
                .FirstOrDefaultAsync(m => m.PizzaId == id);
            if (pizzaModel == null)
            {
                return NotFound();
            }

            return View(pizzaModel);
        }

        public async Task<IActionResult> ConfirmDelete(int id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Index));
            }
            var pizzaToDelete = await _context.Pizzas.FindAsync(id);
            if (pizzaToDelete == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(pizzaToDelete);
        }

        // POST: Pizza/Delete/5
        [HttpPost, ActionName("ConfirmDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pizzaModel = await _context.Pizzas.FindAsync(id);
            _context.Pizzas.Remove(pizzaModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PizzaModelExists(int id)
        {
            return _context.Pizzas.Any(e => e.PizzaId == id);
        }

    }
}
