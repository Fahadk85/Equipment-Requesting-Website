using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using App.Models;

namespace App.Controllers;

public class HomeController : Controller
{
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
}
