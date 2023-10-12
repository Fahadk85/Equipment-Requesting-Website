using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using App.Models;

namespace App.Controllers;

public class HomeController : Controller
{

   private readonly ILogger<HomeController> _logger;

   public HomeController(ILogger<HomeController> logger)
   {
     _logger = logger;
   }

   public IActionResult Index() {
        return View();
   }

   public IActionResult ERform() {
      return View();
   }

   [HttpPost]
   public IActionResult SaveResponse (UserResponse response)
   {
      if (ModelState.IsValid)
      {
         response.Id = response.GenerateUniqueId();

         Repository.AddResponse(response);

         return View("Confirmation",response);
      }
      else {
         return View("ERform", response);
      }
   }

   public IActionResult Confirmation(int Id)
   {
      var response  =Repository.GetAll().FirstOrDefault(x => x.Id == Id);
      return View(response);
   }

   public IActionResult AllEquipment(Equipment equipment)
   {
      Repository.PopulateEquipments();
      var equipments = Repository.GetEquipments();
      return View(equipments);
   }

   [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
