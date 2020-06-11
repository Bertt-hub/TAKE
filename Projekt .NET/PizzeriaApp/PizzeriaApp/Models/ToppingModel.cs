using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzeriaApp.Models
{
    public class ToppingModel
    {
        [Key]
        public int ToppingId { get; set; }
        [Required(ErrorMessage = "Pole nie może być puste.")]
        [MaxLength(25)]
        public string ToppingName { get; set; }
        public virtual ICollection<PizzaToppingModel> PizzaToppings { get; set; }
    }
}
