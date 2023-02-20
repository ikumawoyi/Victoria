using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VictorianPlumbing.Models;
using VictorianPlumbing.Models.Dto;
using VictorianPlumbing.Services;

namespace VictorianPlumbing.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class OrdersController : ControllerBase
	{
		private readonly IOrderService _orderService;

		public OrdersController(IOrderService orderService)
		{
			_orderService = orderService;
		}

		[HttpPost]
		public async Task<OrderResponse> Post(OrderRequest orderRequest)
		{
			return _orderService.Create(orderRequest);
		}
	}
}
