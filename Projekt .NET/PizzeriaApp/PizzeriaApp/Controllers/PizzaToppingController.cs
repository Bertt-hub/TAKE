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
    public class PizzaToppingController : Controller
    {
        private readonly PizzeriaDbContext _context;

        public PizzaToppingController(PizzeriaDbContext context)
        {
            _context = context;
        }

        // GET: PizzaTopping
        public async Task<IActionResult> Index()
        {
            AllDataModel allData = new AllDataModel();
            allData.allPizzas = _context.Pizzas.ToList();
            allData.allPizzasToppings = _context.PizzaToppings.Include(p => p.Pizza).Include(p => p.Topping).ToList();
            return View(allData);
        }

        // GET: PizzaTopping/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pizzaToppingModel = await _context.PizzaToppings
                .Include(p => p.Pizza)
                .Include(p => p.Topping)
                .FirstOrDefaultAsync(m => m.PizzaId == id);
            if (pizzaToppingModel == null)
            {
                return NotFound();
            }

            return View(pizzaToppingModel);
        }

        // GET: PizzaTopping/Create
        public IActionResult Create()
        {
            AllDataModel allData = new AllDataModel();
            allData.allPizzas = _context.Pizzas.ToList();
            allData.allPizzasToppings = _context.PizzaToppings.Include(p => p.Pizza).Include(p => p.Topping).ToList();
            List<PizzaModel> pizzaList = new List<PizzaModel>();
            var foundFlag = false;
            foreach( var pizza in allData.allPizzas)
            {
                foundFlag = false;
                foreach(var pizza2 in allData.allPizzasToppings)
                {
                    if (pizza.PizzaId == pizza2.Pizza.PizzaId)
                    {
                        foundFlag = true;
                    }
                }
                if (!foundFlag)
                {
                    pizzaList.Add(pizza);
                }
            }
            allData.allFreePizzas = pizzaList;
            ViewData["PizzaId"] = new SelectList(allData.allFreePizzas, "PizzaId", "PizzaName");
            ViewData["Toppings"] = _context.Toppings;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int PizzaId, int[] ToppingsIds)
        {
            foreach (int toppingId in ToppingsIds)
            {
                PizzaToppingModel PizzaToping = new PizzaToppingModel();
                PizzaToping.PizzaId = PizzaId;
                PizzaToping.ToppingId = toppingId;
                _context.PizzaToppings.Add(PizzaToping);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        //POST: PizzaTopping/Create
        //To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("PizzaId,ToppingId")] PizzaToppingModel pizzaToppingModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(pizzaToppingModel);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["PizzaId"] = new SelectList(_context.Pizzas, "PizzaId", "PizzaId", pizzaToppingModel.PizzaId);
        //    ViewData["ToppingId"] = new SelectList(_context.Toppings, "ToppingId", "ToppingId", pizzaToppingModel.ToppingId);
        //    return View(pizzaToppingModel);
        //}

        // GET: PizzaTopping/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var toppingsAll = await _context.Toppings.ToListAsync();
            var pizzaTopingsAll = await _context.PizzaToppings.Include(p => p.Pizza).Include(p => p.Topping).ToListAsync();
            var pizzaModel = await _context.Pizzas.FindAsync(id);
            List<ToppingModel> toppingsAvailable = new List<ToppingModel>();

            var foundFlag = false;
            foreach (var topping in toppingsAll)
            {
                foundFlag = false;
                foreach (var toppingUsed in pizzaTopingsAll)
                {
                    if (topping.ToppingId == toppingUsed.Topping.ToppingId && toppingUsed.Pizza.PizzaId == id)
                    {
                        foundFlag = true;
                    }
                }
                if (!foundFlag)
                {
                    toppingsAvailable.Add(topping);
                }
            }

            ViewData["Pizza"] = pizzaModel;
            ViewData["Toppings"] = toppingsAvailable;
            return View();
        }

        // POST: PizzaTopping/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int PizzaId, int[] ToppingsIds)
        {
            foreach (int toppingId in ToppingsIds)
            {
                PizzaToppingModel PizzaToping = new PizzaToppingModel();
                PizzaToping.PizzaId = PizzaId;
                PizzaToping.ToppingId = toppingId;
                _context.PizzaToppings.Add(PizzaToping);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: PizzaTopping/Delete/5
        public async Task<IActionResult> Delete(int? id, int? id2)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pizzaToppingModel = await _context.PizzaToppings
                .Include(p => p.Pizza)
                .Include(p => p.Topping)
                .FirstOrDefaultAsync(m => m.PizzaId == id && m.ToppingId == id2);
            if (pizzaToppingModel == null)
            {
                return NotFound();
            }

            return View(pizzaToppingModel);
        }

        // POST: PizzaTopping/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, [Bind("PizzaId,ToppingId")] PizzaToppingModel pizzaToppingModel)
        {
            //var pizzaToppingModel = await _context.PizzaToppings.FindAsync(id);
            _context.PizzaToppings.Remove(pizzaToppingModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PizzaToppingModelExists(int id)
        {
            return _context.PizzaToppings.Any(e => e.PizzaId == id);
        }
    }
}
