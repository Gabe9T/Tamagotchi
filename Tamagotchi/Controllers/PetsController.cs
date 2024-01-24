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
    [HttpGet("/pets/{id}")]
    public ActionResult Show(int id)
    {
      Pet foundPet = Pet.Find(id);
      return View(foundPet);
    }
    [HttpPost("/pets/feed")] //????
    public ActionResult Update(int id)
    {
      Pets.Feed(id); //??
      return RedirectToAction("Show"); //??
    }
}
}
//feed
//sleep
//time
//play