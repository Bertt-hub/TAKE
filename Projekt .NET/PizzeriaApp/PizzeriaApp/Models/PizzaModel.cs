using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzeriaApp.Models
{
    public class PizzaModel
    {
        [Key]
        [Required(ErrorMessage = "Pole nie może być puste.")]
        public int PizzaId { get; set; }

        [Display (Name="Nazwa")]
        [MaxLength(25)]
        [Required(ErrorMessage ="Pole nie może być puste.")]
        public string PizzaName { get; set; }
        [Display(Name="24 cm")]
        [Range(0, 200.00, ErrorMessage = "Podaj liczbę z przedziału 0 - 200, liczby dziesiętne odziel przecinkiem.")]
        [Required(ErrorMessage = "Pole nie może być puste.")]
        public decimal PriceSmall { get; set; }
        [Display(Name = "32 cm")]
        [Range(0, 200.00, ErrorMessage = "Podaj liczbę z przedziału 0 - 200, liczby dziesiętne odziel przecinkiem.")]
        [Required(ErrorMessage = "Pole nie może być puste.")]
        public decimal PriceMedium { get; set; }
        [Display(Name = "42 cm")]
        [Range(0, 200.00, ErrorMessage = "Podaj liczbę z przedziału 0 - 200, liczby dziesiętne odziel przecinkiem.")]
        [Required(ErrorMessage = "Pole nie może być puste.")]
        public decimal PriceBig { get; set; }
        [Display(Name = "Ciasto")]
        [Required(ErrorMessage = "Pole nie może być puste.")]
        [MaxLength(7)]
        public string Dough { get; set; }

        public virtual ICollection<PizzaToppingModel> PizzaToppings { get; set; }
    }
}
