using HairSalon.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq; //this allows us to use ToList() method below


namespace HairSalon.Controllers
{
  public class ClientsController : Controller
  {
    
    private readonly HairSalonContext _db;
    public StylistsController(HairSalonContext db)
    {
      _db = db;
    }



  }
}