using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        public static listaPizze pizze = null;
        public IActionResult Index()
        {
            if (pizze == null)
            {
                Pizza Margherita = new Pizza(0, "Margherita", "Ingredienti: Mozzarella, Pomodoro e Basilico", 6.50, "img/margherita.jpg");
                Pizza Boscaiola = new Pizza(1, "Boscaiola", "Ingredienti: Mozzarella, Salsiccia e Funghi", 7.50, "img/boscaiola.jpg");
                Pizza Bufala = new Pizza(2, "Bufala", "Ingredienti: Mozzarella di bufala, Pomodoro e Basilico", 7.50, "img/bufala.jpg");
                Pizza Formaggi = new Pizza(3, "Formaggi", "Ingredienti: Mozzarella, Gorgonzola, Fontina e Taleggio", 9.00, "img/formaggi.webp");
                Pizza Salame = new Pizza(4, "Salame", "Ingredienti: Mozzarella, pomodoro e Salame piccante", 8.50, "img/salame.jpg");
                Pizza Funghi = new Pizza(5, "Funghi", "Ingredienti: Mozzarella, pomodoro e Funghi", 7.00, "img/funghi.jpg");

                pizze = new();
                pizze.pizzas.Add(Margherita);
                pizze.pizzas.Add(Boscaiola);
                pizze.pizzas.Add(Bufala);
                pizze.pizzas.Add(Formaggi);
                pizze.pizzas.Add(Salame);
                pizze.pizzas.Add(Funghi);
            }
            

            return View(pizze);
        }


        public IActionResult Show(int id)
        { 
            return View("Show", pizze.pizzas[id]);
        }

        public IActionResult CreaNuovaPizza()
        {
            Pizza NuovaPizza = new Pizza()
            {
                Id = 0,
                Name = "",
                Description = "",
                Price = 0.0,
                Photo = "",
                
            };
            
            return View(NuovaPizza);
        }

        public IActionResult ShowPizza(Pizza pizza)
        {
            Pizza nuovaPizza = new Pizza()
            {
                Id = pizza.Id,
                Name = pizza.Name,
                Description = pizza.Description,
                Price = pizza.Price,
                Photo = pizza.Photo,
                
            };
            pizze.pizzas.Add(nuovaPizza);
            return View("ShowPizza", nuovaPizza);
        }
    }
}
