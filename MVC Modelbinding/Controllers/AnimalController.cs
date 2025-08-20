using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language.Intermediate;
using MVC_Modelbinding.Models;
using System.Net.Sockets;
using System.Security.AccessControl;

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

    // Function to add to database
    //try
    //{
    //    using (var connection = new SqlConnection(connectionString)) {
    //        connection.Open();
            
    //        var sql = $"INSERT INTO Animals (CommonName, Class, Family, Genus, LifeSpan) ...";
            
    //        command.Parameters.AddWithValue("@CommonName", animal.CommonName);
    //        command.Parameters.AddWithValue("@CommonName", animal.Class);
    //        ...
    //        command.Parameters.AddWithValue("@CommonName", animal.LifeSpan);
            
    //        using (var command = new SqlCommand(sql, connection))
    //        {
    //            command.ExecuteNonQuery();
    //        }
    //}
    //catch (SqlException ex)
    //{
    //   Console.WriteLine($"Failed to create animal : SQL Error => {ex.Number}, {ex.Message}");
    //}
}
