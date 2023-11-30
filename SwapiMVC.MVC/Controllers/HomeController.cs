using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SwapiMVC.Models;

namespace SwapiMVC.MVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public async Task<IActionResult> Index()
    {
        Random rand = new Random();
        string[] names = new[] { "Kady", "Sy", "Greg", "Hek", "Sweetpea", "Laney", "Quest" };

        string name = names[rand.Next(0, names.Length)];

        return View(model: name);
    }

    public async Task<IActionResult> Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public async Task<IActionResult> Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
