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
    [HttpGet("/pets/{id}")] //specific detail page
    public ActionResult Show(int id)
    {
      Pet foundPet = Pet.Find(id);
      return View(foundPet);
    }
    
    [HttpPost("/pets/feed/{id}")] 
    public ActionResult UpdateFood(int id)
    {
      Pet foundPet = Pet.Find(id);
      foundPet.Feed();
      return RedirectToAction("Show", new { id });
    }
     [HttpPost("/pets/play/{id}")] 
    public ActionResult UpdateAttention(int id)
    {
      Pet foundPet = Pet.Find(id);
      foundPet.Play();
      return RedirectToAction("Show", new { id });
    }

    [HttpPost("/pets/rest/{id}")]
    public ActionResult UpdateRest(int id)
    {
      Pet foundPet = Pet.Find(id);
      foundPet.Sleep();
      return RedirectToAction("Show", new { id });
    }

  }
}

//time
