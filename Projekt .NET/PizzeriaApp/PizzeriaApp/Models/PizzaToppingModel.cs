using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PizzeriaApp.Models
{
    public class PizzaToppingModel
    {
        [Key, Column(Order = 1)]
        public int PizzaId { get; set; }
        [Key, Column(Order = 2)]
        public int ToppingId { get; set; }

        public virtual PizzaModel Pizza { get; set; }
        public virtual ToppingModel Topping { get; set; }
    }
}
