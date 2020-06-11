using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PizzeriaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzeriaApp.Data
{
    public class PizzeriaDbContext : DbContext {
        public PizzeriaDbContext(DbContextOptions<PizzeriaDbContext> options) : base(options) { } 
        public DbSet<PizzaModel> Pizzas { get; set; } 
        public DbSet<ToppingModel> Toppings { get; set; }
        public DbSet<PizzaToppingModel> PizzaToppings { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PizzaToppingModel>()
                .HasKey(x => new { x.PizzaId, x.ToppingId });
        }
    }
}
