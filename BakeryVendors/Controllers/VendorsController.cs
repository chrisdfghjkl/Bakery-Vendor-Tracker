using Microsoft.AspNetCore.Mvc;
using BakeryVendors.Models;
using System.Collections.Generic;
using System;

namespace BakeryVendors.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendors> allVendors = Vendors.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorDescription)
    {
      Vendors newVendor = new Vendors(vendorName, vendorDescription);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{vendorId}")]
    public ActionResult Show(int VendorId)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendors vendorSelection = Vendors.Find(VendorId);
      List<Order> orderList = vendorSelection.Orders;
      model.Add("vendor", vendorSelection);
      model.Add("orders", orderList);
      return View("Show", model);
    }
  }
}