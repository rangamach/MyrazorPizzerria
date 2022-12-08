using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyRazorPizzerria.Models;

namespace MyRazorPizzerria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> InMemoryPizzaDB = new List<PizzasModel>()
        {
            new PizzasModel(){ imageTitle="Margerita",PizzaName="Margharita",BasePrice=2,tomatoSauce=true,cheese=true,finalPrice=4},
            new PizzasModel(){ imageTitle="Bolognese",PizzaName="Bolognese",BasePrice=3,pepperoni=true,cheese=true,finalPrice=5},
            new PizzasModel(){ imageTitle="Carbonara",PizzaName="Carbanara",BasePrice=5,tomatoSauce=true,cheese=true,mushroom=true,finalPrice=8},
            new PizzasModel(){ imageTitle="Hawaiian",PizzaName="Hawaiian",BasePrice=6,tomatoSauce=true,cheese=true,corn=true,mushroom=true,finalPrice=10},
            new PizzasModel(){ imageTitle="Mushroom",PizzaName="Mushroom",BasePrice=2,mushroom=true,tomatoSauce=true,cheese=true,finalPrice=5},
            new PizzasModel(){ imageTitle="Pepperoni",PizzaName="Pepperoni",BasePrice=2,pepperoni=true,tomatoSauce=true,cheese=true,finalPrice=5},
            new PizzasModel(){ imageTitle="Vegetarian",PizzaName="Vegetarian",BasePrice=2,capsicum=true,olive=true,paneer=true,corn=true,mushroom=true,tomatoSauce=true,cheese=true,finalPrice=9},
             new PizzasModel(){ imageTitle="peppypaneer",PizzaName="Peppy Paneer",BasePrice=8,paneer=true,tomatoSauce=true,cheese=true,finalPrice=11},
              new PizzasModel(){ imageTitle="MexicanGreenWave",PizzaName="Mexican Green Wave",BasePrice=6,capsicum=true,olive=true,corn=true,tomatoSauce=true,cheese=true,finalPrice=11}
        };
        public void OnGet()
        {
        }
    }
}
