using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;
using System.Collections.Generic;

namespace Tamagotchi.Controllers 
{
  public class PetsController : Controller
  {
      [HttpGet("/pets")]
    public ActionResult Index() 
    {
      List<Pet> allPets = Pet.GetAll();
      return View(allPets);
    }
    [HttpGet("/pets/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpPost("/pets")]
    public ActionResult Create(string name)
    {
      Pet newPet = new Pet(name);
      return RedirectToAction("Index");
    }
}
}
//feed
//sleep
//time
//play