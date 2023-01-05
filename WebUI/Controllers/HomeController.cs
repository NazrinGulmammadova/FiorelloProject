using DataAccess.Contexts;
using Microsoft.AspNetCore.Mvc;
using WebUI.ViewModels;

namespace WebUI.Controllers;

public class HomeController : Controller
{
    private readonly AppDbcontext _context;

    public HomeController(AppDbcontext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        HomeVM homeVM = new HomeVM()
        {
            SlideItems = _context.SlideItems,
            SlideTexts = _context.SlideTexts.FirstOrDefault()
        };
        return View(homeVM);
    }
}
