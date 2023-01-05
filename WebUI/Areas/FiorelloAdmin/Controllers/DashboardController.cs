using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Areas.FiorelloAdmin.Controllers;
[Area("FiorelloAdmin")]
public class DashboardController : Controller
{

    public IActionResult Index()
    {
        return View();
    }
}
