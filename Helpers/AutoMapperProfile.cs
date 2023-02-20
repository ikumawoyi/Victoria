using AutoMapper;
using VictorianPlumbing.Models;
using VictorianPlumbing.Models.Dto;

namespace VictorianPlumbing.Helpers
{
	public class AutoMapperProfile : Profile
	{
        public AutoMapperProfile()
        {
            CreateMap<OrderRequest, Order>();

        }
    }
}
