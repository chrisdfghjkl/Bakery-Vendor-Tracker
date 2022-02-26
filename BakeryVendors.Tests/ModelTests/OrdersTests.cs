using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BakeryVendors.Models;
using System;

namespace BakeryVendors.Tests
{
  [TestClass]
  public class OrdersTests
  {

    [TestMethod]
    public void Order_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnOrderTitle_String()
    {
      string orderTitle = "Cafe order 1";
      Order newOrder = new Order(orderTitle);

      string title = newOrder.OrderTitle;

      Assert.AreEqual(title, orderTitle);
    }
  }
}