namespace VictorianPlumbing.Models
{
	public class ShoppingCartItem
	{
		public string ShoppingCartItemId { get; set; }
		public string OrderId { get; set; }
		public int Quantity { get; set; }
		public double Price { get; set; }
		public string ProductId { get; set; }
		public string ProductName { get; set; }
	}
}
