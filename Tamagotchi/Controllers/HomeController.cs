using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;

namespace Tamagotchi.Controllers 
{
  public class HomeController : Controller
  {
    [Route("/hello")]
    public string Hello() { return "Hello friend!"; }
    // [Route("/")]
    // public ActionResult Index() //routeMethodName
    // {
      
    // }
  //}
}
}

//feed
//sleep
//time
//play