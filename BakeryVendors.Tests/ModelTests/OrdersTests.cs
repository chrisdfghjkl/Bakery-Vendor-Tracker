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
      Order newOrder = new Order("test", "description", 10);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnOrderTitle_String()
    {
      string orderTitle = "Cafe order 1";
      Order newOrder = new Order(orderTitle, "order description", 10);

      string title = newOrder.OrderTitle;

      Assert.AreEqual(title, orderTitle);
    }

    [TestMethod]
    public void GetDescription_ReturnsOrderDescription_String()
    {
      string orderDescription = "ten bread loaves, 30 pastries";
      Order newOrder = new Order("order title,", orderDescription, 5);

      string details = newOrder.OrderDescription;

      Assert.AreEqual(details, orderDescription);
    }

    [TestMethod]
    public void GetPrice_ReturnsOrderPrice_Int()
    {
      int orderPrice = 10;
      Order newOrder = new Order("Bob's", "Red Mill", orderPrice);

      int invoice = newOrder.OrderPrice;

      Assert.AreEqual(10, orderPrice);
    }
  }
}