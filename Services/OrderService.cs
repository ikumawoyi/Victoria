using AutoMapper;
using System.Collections.Generic;
using VictorianPlumbing.Context;
using VictorianPlumbing.Models;
using VictorianPlumbing.Models.Dto;

namespace VictorianPlumbing.Services
{

	public interface IOrderService
	{
		OrderResponse Create(OrderRequest model);
	}
	public class OrderService : IOrderService
    {
        private VictoriaPlumbingDbContext _context;
        private readonly IMapper _mapper;
        public OrderService(
        VictoriaPlumbingDbContext context,
        IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public OrderResponse Create(OrderRequest model)
		{
            // validate
            if (!_context.Products.Any(x => x.id == model.productid)) 
                throw new ArgumentNullException("Product with the id '" + model.productid + "' does not exists");
           
            // map model to new Order object
            Random rnd = new Random();
            var order = _mapper.Map<Order>(model);
            double price = 0;
            List<double> totalPrice = new List<double>();
            ShoppingCartItem cart = new ShoppingCartItem();
            OrderResponse orderRes = new OrderResponse();

            foreach (var orderitem in model.OrderItems)
            {
                cart.Price = orderitem.price;
                cart.Quantity = orderitem.quatity;
                cart.ProductName = orderitem.productname;
                cart.ShoppingCartItemId = orderitem.productid;
                cart.OrderId = orderitem.productid;
                price = cart.Price * cart.Quantity;
                totalPrice.Add(price);
                cart.ProductId = orderitem.productid;
                _context.ShoppingCartItems.Add(cart);
                order.Items.Add(cart);
            }
            order.OrderNumber = rnd.Next(10000000, 99999999);
            order.OrderId = model.productid;
            _context.Orders.Add(order);
            _context.SaveChanges();
			foreach (var item in totalPrice)
			{
                orderRes.totalprice += item;
            }
            orderRes.orderNumber = order.OrderNumber;
            orderRes.EmailAddress = order.EmailAddress;
            orderRes.Date = order.OrderDate;
            orderRes.Name = cart.ProductName;
            orderRes.PostCode = order.PostCode;
            orderRes.totalitems = order.Items.Count;


            return orderRes;

        }
	}
}
