using System.ComponentModel.DataAnnotations;

namespace VictorianPlumbing.Models
{
	public class Order
	{
	[Key]
        //public string OrderId { get; set; } = Guid.NewGuid().ToString();
    public string OrderId { get; set; } //Use this when loading from given payload
    public int OrderNumber { get; set; }
    public DateTime OrderDate { get; set; } = DateTime.Now;

	// Customer Details
	public string FirstName { get; set; }
    public string LastName { get; set; }
    public string EmailAddress { get; set; }

    // BillingAddress
    public string AddressLine { get; set; }
    public string Country { get; set; }
    public string State { get; set; }
    public string PostCode { get; set; }

    // ShoppingCart
    public List<ShoppingCartItem> Items { get; set; } = new List<ShoppingCartItem>();


		public double Totalprice { get; set; }
	}
}



