using DersModelYapisi.Models;
using Microsoft.AspNetCore.Mvc;

namespace DersModelYapisi.Controllers
{
	public class CartController : Controller
	{
		public static List<CartProductViewModel> cartProducts = new();
		public IActionResult Index()
		{
			var product1 = new ProductViewModel { Id = 1, Name = "Product1", Price = 1499.78M };
			var product2 = new ProductViewModel { Id = 2, Name = "Product2", Price = 2499.99M };
			var product3 = new ProductViewModel { Id = 3, Name = "Product3", Price = 3499.19M };

			var cartProduct1 = new CartProductViewModel { Id = 1, Product = product1, Quantity = 5 };
			var cartProduct2 = new CartProductViewModel { Id = 2, Product = product2, Quantity = 4 };
			var cartProduct3 = new CartProductViewModel { Id = 3, Product = product3, Quantity = 3 };

			cartProducts.Add(cartProduct1);
			cartProducts.Add(cartProduct2);
			cartProducts.Add(cartProduct3);
			return View(cartProducts);
		}
	}
}
