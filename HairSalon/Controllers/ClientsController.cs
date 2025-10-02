using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Controllers
{
  public class ClientsController : Controller
  {
    private readonly HairSalonContext _db;

    public ClientsController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Clients.ToList());
    }

    public ActionResult Create()
    {
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Client client, int StylistId)
    {
        _db.Clients.Add(client);
        _db.SaveChanges();
        if (StylistId != 0)
        {
            _db.StylistClient.Add(new StylistClient() { StylistId = StylistId, ClientId = client.ClientId });
            _db.SaveChanges();
        }
        return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
        var thisClient = _db.Clients
            .Include(client => client.JoinEntities)
            .ThenInclude(join => join.Stylist)
            .FirstOrDefault(client => client.ClientId == id);
        return View(thisClient);
    }

    public ActionResult Edit(int id)
    {
      var thisClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
      return View(thisClient);
    }

    [HttpPost]
    public ActionResult Edit(Client client, int StylistId)
    {
      if (StylistId != 0)
      {
        _db.StylistClient.Add(new StylistClient() { StylistId = StylistId, ClientId = client.ClientId });
      }
      _db.Entry(client).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult AddStylist(int id)
    {
      var thisClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name", "specialty");
      return View(thisClient);
    }

    [HttpPost]
    public ActionResult AddStylist(Client client, int StylistId)
    {
      if(StylistId != 0)
      {
        _db.StylistClient.Add(new StylistClient() { StylistId = StylistId, ClientId = client.ClientId });
        _db.SaveChanges();
      }
      return RedirectToAction("Index");
    }

//     public ActionResult Delete(int id)
//     {
//       var thisClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
//       return View(thisClient);
//     }

//     [HttpPost, ActionName("Delete")]
//     public ActionResult DeleteConfirmed(int id)
//     {
//       var thisClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
//       _db.Clients.Remove(thisClient);
//       _db.SaveChanges();
//       return RedirectToAction("Index");
//     }
  }
}