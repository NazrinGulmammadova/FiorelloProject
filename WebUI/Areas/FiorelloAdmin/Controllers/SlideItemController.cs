using DataAccess.Contexts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Areas.FiorelloAdmin.Controllers;
[Area("FiorelloAdmin")]
public class SlideItemController : Controller
{
    private readonly AppDbcontext _context;
    private readonly IWebHostEnvironment _env;
    public SlideItemController(AppDbcontext context, IWebHostEnvironment env)
    {
        _context = context;
        _env = env;
    }

    public IActionResult Index()
    {
        return View(_context.SlideItems);
    }
    public async Task<IActionResult> Detail(int id)
    {
        var model = await _context.SlideItems.FindAsync(id);
        if(model == null) return NotFound();
        return View();
    }
}
