using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyAspNetCoreApp.Models;

namespace MyAspNetCoreApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

  // Home page
    public IActionResult Index()
    {
        return View();
    }

    // About page
    public IActionResult About()
    {
        return View();
    }

    // Data page
    public IActionResult Data()
    {
        return View();
    }

    // Contact page
    public IActionResult Contact()
    {
        return View();
    }

    // Login Page
    public IActionResult Login()
    {
        return View();
    }
               
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
