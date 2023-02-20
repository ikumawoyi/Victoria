using AutoMapper;
using VictorianPlumbing.Context;
using VictorianPlumbing.Helpers;
using VictorianPlumbing.Models;

namespace VictorianPlumbing.Services
{
    public interface IProductService
    {
        void Create();
    }
    public class ProductService : IProductService 
	{
        private VictoriaPlumbingDbContext _context;
        private readonly Loader _loader;
        private readonly IMapper _mapper;
        public ProductService(
        VictoriaPlumbingDbContext context,
        IMapper mapper, Loader loader)
        {
            _context = context;
            _mapper = mapper;
            _loader = loader;
        }

        
        public void Create()
        {
           var products = _loader.LoadProduct();
			foreach (var model in products)
			{
                if (_context.Products.Any(x => x.id == model.id))
                    throw new ArgumentNullException("Product with the id '" + model.id + "' already exists");
                var product = _mapper.Map<Product>(model);
                _context.Products.Add(product);
            }
            _context.SaveChanges();
        }

    }
}
