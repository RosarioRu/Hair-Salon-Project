using HairSalon.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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


    [HttpGet]
    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Stylist stylistToAdd)
    {
      _db.Stylists.Add(stylistToAdd);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpGet]
    public ActionResult Details(int id)
    {
      Stylist stylistToDisplay = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
      ViewBag.HasClientsOrNot = _db.Clients.FirstOrDefault(client => client.StylistId == id);
      List<Client> ThisStylistClientsInListForm = _db.Clients.Where(client => client.StylistId == id).ToList();
      ViewBag.StylistClientsInListForm = ThisStylistClientsInListForm;
      return View(stylistToDisplay);
    }


    

  }  
}