using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
using System.Collections.Generic;

namespace Bakery.Controllers
{
  public class BreadsController : Controller
  {

    [HttpGet("/breads")]
    public ActionResult Index()
    {
      List<Bread> allBreads = Bread.GetBreadList();
      return View(allBreads);
    }

    [HttpPost("/breads")]
    public ActionResult CreateOrder(int typeNumber, int quantity)
    {
      Bread newBreadOrder = new Bread(typeNumber, quantity);
      Bread.TotalPrice = Bread.GetBreadPrice();
      return RedirectToAction("Index");
    }

    [HttpGet("/breads/new")]
    public ActionResult BreadForm()
    {
      return View();
    }

  }
}   