namespace VictorianPlumbing.Models.Dto
{
    public class OrderResponse
    {
        public string orderid { get; set; }
        public int orderNumber { get; set; }
        public double totalprice { get; set; }
        public int totalitems { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string PostCode { get; set; }
        public List<Item> items { get; set; }
    }

    public class Item
    {
        public int quatity { get; set; }
        public double price { get; set; }
        public string productid { get; set; }
        public string productname { get; set; }
    }
}
