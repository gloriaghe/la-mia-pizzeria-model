using la_mia_pizzeria_static.Data;
using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {

            PizzaDbContext db = new PizzaDbContext();

            List<Pizza> listaPizze = db.Pizzas.ToList();
            return View(listaPizze);
        }

        public IActionResult Detail(int id)
        {
            PizzaDbContext db = new PizzaDbContext();

            Pizza pizza = db.Pizzas.Where(pizza => pizza.Id == id).FirstOrDefault();
            if (pizza == null)
                return View("Errore", "Pizza non trovata");

            return View(pizza);

        }
    }
}