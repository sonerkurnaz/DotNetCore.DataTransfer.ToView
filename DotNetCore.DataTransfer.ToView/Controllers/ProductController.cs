using DotNetCore.DataTransfer.ToView.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore.DataTransfer.ToView.Controllers
{
    public class ProductController : Controller
    {
        public List<Product> GetProductList
        {
            get
            {

            }
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
