using HairSalon.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq; //this allows us to use ToList() method below


namespace HairSalon.Controllers
{
  public class ClientsController : Controller
  {

    private readonly HairSalonContext _db;
    public ClientsController(HairSalonContext db)
    {
      _db = db;
    }

    [HttpGet]
    public ActionResult Index()
    {
      List<Client> model = _db.Clients.ToList();
      return View(model);
    }

    [HttpGet]
    public ActionResult CreateClient()
    {
      
      if (_db.Stylists.Count() == 0)
      {
        return RedirectToAction("Create", "Stylists");
      }
      else
      {
        ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "StylistFirstName");
        return View();
      }
    }

    [HttpPost]
    public ActionResult CreateClient(Client clientToAdd)
    {
      _db.Clients.Add(clientToAdd);
      _db.SaveChanges();
      return RedirectToAction("Index", "Clients");
    }
  

    [HttpGet]
    public ActionResult Create(int id)
    {
      ViewBag.Stylist= _db.Stylists.FirstOrDefault(Stylist => Stylist.StylistId == id);
      ViewBag.StylistName = ViewBag.Stylist.StylistFirstName;
      ViewBag.StylistID = ViewBag.Stylist.StylistId;
      
      return View();
    }

    [HttpPost]
    public ActionResult Create(Client clientToAdd)
    {
      _db.Clients.Add(clientToAdd);
      _db.SaveChanges();
      return RedirectToAction("Index", "Stylists");
    }



  }
}