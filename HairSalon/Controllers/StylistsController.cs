using HairSalon.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Controllers
{
  public class StylistsController : Controller
  {

    private readonly HairSalonContext _db;
    public StylistsController(HairSalonContext db)
    {
      _db = db;
    }

    [HttpGet]
    public ActionResult Index() 
    { 
      List<Stylist> model = _db.Stylists.ToList();
      return View(model);
    }

  }  
}