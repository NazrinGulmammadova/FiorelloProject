using DataAccess.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Areas.FiorelloAdmin.Controllers;

public class SlideTextController : Controller
{
    private readonly AppDbcontext _context;
    private readonly IWebHostEnvironment _env;
    public SlideTextController(AppDbcontext context, IWebHostEnvironment env)
    {
        _context = context;
        _env = env;
    }

    public IActionResult Index()
    {
        return View(_context.SlideTexts);
    }
}
