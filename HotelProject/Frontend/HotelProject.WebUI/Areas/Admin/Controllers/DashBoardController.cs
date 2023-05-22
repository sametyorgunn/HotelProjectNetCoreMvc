using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
