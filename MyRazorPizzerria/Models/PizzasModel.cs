namespace MyRazorPizzerria.Models
{
    public class PizzasModel
    {
        public string imageTitle { get; set; }
        public string PizzaName { get; set; }
        public float BasePrice { get; set; } = 2;
        public bool tomatoSauce { get; set; }
        public bool cheese { get; set; }
        public bool pepperoni { get; set; }
        public bool mushroom { get; set; }
        public bool paneer { get; set; }
        public bool olive { get; set; }
        public bool capsicum { get; set; }
        public bool corn { get; set; }
        public float finalPrice { get; set; }
    }
}
