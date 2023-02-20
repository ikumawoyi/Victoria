using Newtonsoft.Json;
using System.Collections.Generic;
using VictorianPlumbing.Models;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace VictorianPlumbing.Helpers
{
	public class Loader
	{
        private readonly IWebHostEnvironment _webHostEnvironment;
        public Loader(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        public List<Product> LoadProduct()
        {
            List<Product> ppp = new List<Product>();
            var rootPath = _webHostEnvironment.ContentRootPath; 
            var fullPath = Path.Combine(rootPath, "example-payload.json"); 
            var jsonProducts = File.ReadAllText(fullPath); 
            if (string.IsNullOrWhiteSpace(jsonProducts)) throw new ArgumentNullException("Product file is empty"); 

            Root myDeserializedClass  = JsonConvert.DeserializeObject<Root>(jsonProducts); 
            if (myDeserializedClass == null) throw new ArgumentNullException("Product is empty"); 
			foreach (var item in myDeserializedClass.products)
			{
                ppp.Add(item);
			}
            return ppp;
        }
    }
}
