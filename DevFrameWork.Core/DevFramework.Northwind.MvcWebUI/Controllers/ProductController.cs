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
                ProductName = "Laptop2",
                QuantityPerUnit = "1",
                UnitPrice = 30
            });
            return "Added";
        }

        public string AddUpdate()
        {
            _productService.TransactionalOperation(new Product
            {
                CategoryID = 1,
                ProductName = "Telefon1",
                QuantityPerUnit = "1",
                UnitPrice = 5
            }, new Product
            {
                ProductID = 11078,
                CategoryID = 1,
                ProductName = "Laptop1",
                QuantityPerUnit = "1",
                UnitPrice = 3500
            });
            return "Done";
        }
    }
}