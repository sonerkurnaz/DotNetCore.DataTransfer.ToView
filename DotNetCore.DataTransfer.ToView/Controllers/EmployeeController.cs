using Microsoft.AspNetCore.Mvc;

namespace DotNetCore.DataTransfer.ToView.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
