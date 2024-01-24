using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;

namespace Tamagotchi.Controllers 
{
  public class PetsController : Controller
  {
    [Route("/hello")]
    public string Hello() { return "Hello friend!"; }
    
  }
}

//feed
//sleep
//time
//play