using DevFramework.Northwind.Business.Abstract;
using DevFramework.Northwind.Entities.Concerete;
using DevFramework.Northwind.MvcWebUI.Models;
using System.Web.Mvc;

namespace DevFramework.Northwind.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public ActionResult Index()
        {
            var model = new ProductListViewModel
            {
                Products = _productService.GetAll()
            };
            return View(model);
        }

        public string Add()
        {
            _productService.Add(new Product
            {
                CategoryID = 1,
                ProductName = "Telefon",
                QuantityPerUnit = "1",
                UnitPrice = 35
            });
            return "Added";
        }
    }
}