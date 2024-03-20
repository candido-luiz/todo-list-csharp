using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TodoList.Models;
using TodoList.ViewModels;

namespace TodoList.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private static List<TodoTask> listaTasks = new List<TodoTask>();

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.ListaTasks = listaTasks;

        return View();
    }

    [HttpPost]
    public IActionResult AdicionarTask(TodoTask novaTask)
    {
        // novaTask.Id =  Guid.NewGuid(); // Define o ID da nova task
        listaTasks.Add(novaTask); // Adiciona a nova task à lista
        return RedirectToAction("Index", "Home"); // Redireciona para a página inicial ou outra página desejada
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
