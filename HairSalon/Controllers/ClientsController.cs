using HairSalon.Models;
using Microsoft.AspNetCore.Mvc;
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