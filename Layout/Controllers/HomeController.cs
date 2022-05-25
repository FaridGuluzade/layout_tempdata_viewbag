using Layout.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Layout.Controllers
{
    public class HomeController : Controller
    {
        public List<Card> Cards { get; set; }

        public HomeController()
        {
            Cards = new List<Card>()
            {
                new Card()
                {
                     Id= 1,
                    Title = "Title1"

                },
                new Card()
                 {
                Id = 2,
                Title = "Title2"

                 },
                new Card()
                {
                    Id= 3,
                    Title = "Title3"

                },
                new Card()
                {
                     Id= 4,
                    Title = "Title4"

                },
                new Card()
                {
                     Id= 5,
                    Title = "Title5"

                },
                new Card()
                {
                Id = 6,
                Title = "Title6"

                }

            };
    }

        public IActionResult Index()
        {
      
            return View(Cards);
        }

        public IActionResult Details(int id)
        {
            Card card = Cards.Find(n => n.Id == id);

            if (card == null)
            {
                return View("_ErrorPage");
            }

            return View(card);
        }
    }

}
