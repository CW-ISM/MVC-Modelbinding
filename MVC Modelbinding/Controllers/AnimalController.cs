using Microsoft.AspNetCore.Mvc;
using MVC_Modelbinding.Models;

namespace MVC_Modelbinding.Controllers;

public class AnimalController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Animal animal)
    {
        if (ModelState.IsValid)
        {
            TempData["Message"] = "Animal was added successfully";
            return RedirectToAction("Index");
        }

        return View(animal);
    }
}
