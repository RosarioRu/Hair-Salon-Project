using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;

namespace HairSalon.Controllers
{
  public class StylistsController : Controller
  {

    [HttpGet]
    public ActionResult Index() 
    { 
      return View();
    }

  }  
}