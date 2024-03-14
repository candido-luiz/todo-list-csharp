using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TodoList.Models;
using TodoList.ViewModels;

namespace TodoList.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var myTask = new TodoTask
        {
            Title = "Primeira Task",
            CreatedAt = DateTime.Now,
            Status = Enums.StatusEnum.Active,
        };

        return View(myTask);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
