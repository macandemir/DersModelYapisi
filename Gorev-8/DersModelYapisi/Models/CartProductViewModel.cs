using System.Runtime.CompilerServices;

namespace DersModelYapisi.Models
{
	public class CartProductViewModel
	{
		public int Id { get; set; }
		public ProductViewModel Product { get; set; }
		public int Quantity { get; set; }
		public decimal Price
		{
			get
			{
				return this.Product.Price * this.Quantity;
			}
			set
			{
				
			}
		}
	}
}
