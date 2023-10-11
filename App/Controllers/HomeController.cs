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

}
