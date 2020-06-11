using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzeriaApp.Models
{
    public class AllDataModel
    {
        public List<PizzaModel> allPizzas { get; set; }
        public List<ToppingModel> allToppings { get; set; }
        public List<PizzaToppingModel> allPizzasToppings { get; set; }
        public List<PizzaModel> allFreePizzas { get; set; }
    }
}
