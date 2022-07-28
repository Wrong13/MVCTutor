using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class HomeController : Controller
{
    private BnsContext db;

    public HomeController()
    {
        db = new BnsContext();
        db.Users.Load();
    }
    // GET
    public IActionResult Index()
    {
        
        return View();
    }
}