using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyRazorPizzerria.Models;

namespace MyRazorPizzerria.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel pizza { get; set; }
        public float pizzaPrice { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            pizzaPrice = pizza.BasePrice;
            if (pizza.tomatoSauce) pizzaPrice += 1;
            if (pizza.cheese) pizzaPrice += 1;
            if (pizza.pepperoni) pizzaPrice += 1;
            if (pizza.mushroom) pizzaPrice += 1;
            if (pizza.paneer) pizzaPrice += 1;
            if (pizza.olive) pizzaPrice += 1;
            if (pizza.capsicum) pizzaPrice += 1;
            if (pizza.corn) pizzaPrice += 1;
            return RedirectToPage("/Checkout/Checkout",new { pizza.PizzaName,pizzaPrice });
        }
    }
}
