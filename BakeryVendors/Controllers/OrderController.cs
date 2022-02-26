using Microsoft.AspNetCore.Mvc;
using BakeryVendors.Models;
using System.Collections.Generic;

namespace BakeryVendors.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int VendorId)
    {
      Vendors vendor = Vendors.Find(VendorId);
      return View(vendor);
    }

    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int VendorId, int OrderId)
    {
      Order order = Order.Find(OrderId);
      Vendors vendor = Vendors.Find(VendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", order);
      model.Add("vendor", vendor);
      return View(model);
    }
  }
}