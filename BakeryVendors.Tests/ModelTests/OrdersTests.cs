using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BakeryVendors.Models;
using System;

namespace BakeryVendors.Tests
{
  [TestClass]
  public class OrdersTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void Order_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test", "description");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnOrderTitle_String()
    {
      string orderTitle = "Cafe order 1";
      string orderDescription = "gluten free";
      Order newOrder = new Order(orderTitle, orderDescription);

      string title = newOrder.OrderTitle;

      Assert.AreEqual(title, orderTitle);
    }

    [TestMethod]
    public void GetDescription_ReturnsOrderDescription_String()
    {
      string orderTitle = "Cafe order 1";
      string orderDescription = "ten bread loaves, 30 pastries";
      Order newOrder = new Order(orderTitle, orderDescription);

      string details = newOrder.OrderDescription;

      Assert.AreEqual(details, orderDescription);
    }
  }
}