namespace VictorianPlumbing.Models.Dto
{
	public class OrderRequest
	{
        public string productid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string AddressLine { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string PostCode { get; set; }
        public List<OrderItem> OrderItems { get; set; }

        public class OrderItem
        {
            public int quatity { get; set; }
            public double price { get; set; }
            public string productid { get; set; }
            public string productname { get; set; }
        }
    }
}
