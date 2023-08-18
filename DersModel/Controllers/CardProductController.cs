using DersModel.Models;
using DersModel.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DersModel.Controllers
{
    public class CardProductController : Controller
    {
        public IActionResult Index()
        {
            var product1 = new Product { Id = 1, Name = "Kamera", Price = 2000 };
            var product1 = new Product { Id = 1, Name = "Kamera", Price = 2000 };
            var product1 = new Product { Id = 1, Name = "Kamera", Price = 2000 };

            var cardProduct1 = new CardProduct { Product = product1, Quantity = 5, Id = 1, Price = 1400 };
            var cardProduct1 = new CardProduct { Product = product1, Quantity = 5, Id = 1, Price = 1400 };
            var cardProduct1 = new CardProduct { Product = product1, Quantity = 5, Id = 1, Price = 1400 };

            List<CardProduct> cardProducts = new List<CardProduct>();
            cardProducts.Add(cardProduct1);
            cardProducts.Add(cardProduct2);
            cardProducts.Add(cardProduct3);

            CardProductViewModel datas = new CardProductViewModel {  products =  cardProducts };

            return View(datas);
        }
    }
}
