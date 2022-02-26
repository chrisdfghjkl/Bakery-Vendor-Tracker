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
      Order newOrder = new Order("test", "description", 10, "02/26/2022");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnOrderTitle_String()
    {
      string orderTitle = "Cafe order 1";
      Order newOrder = new Order(orderTitle, "order description", 10, "02/26/2022");

      string title = newOrder.OrderTitle;

      Assert.AreEqual(title, orderTitle);
    }

    [TestMethod]
    public void GetDescription_ReturnsOrderDescription_String()
    {
      string orderDescription = "ten bread loaves, 30 pastries";
      Order newOrder = new Order("order title,", orderDescription, 5, "02/26/2022");

      string details = newOrder.OrderDescription;

      Assert.AreEqual(details, orderDescription);
    }

    [TestMethod]
    public void GetPrice_ReturnsOrderPrice_Int()
    {
      int orderPrice = 10;
      Order newOrder = new Order("Bob's", "Red Mill", orderPrice, "02/26/2022");

      int invoice = newOrder.OrderPrice;

      Assert.AreEqual(invoice, orderPrice);
    }

    [TestMethod]
    public void GetDate_ReturnsDateOrderPlaced_String()
    {
      string orderDate = "02/26/2022";
      Order newOrder = new Order("Bob's", "Red Mill", 45, orderDate);

      string orderPlaced = newOrder.OrderDate;

      Assert.AreEqual(orderPlaced, orderDate);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };
      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsListOfOrders_OrderList()
    {
      string orderTitle1 = "Bread order";
      string orderDescription1 = "10 loaves of bread";
      int orderPrice1 = 50;
      string orderDate1 = "02/26/2022";
      string orderTitle2 = "Pastry order";
      string orderDescription2 = "20 pastries";
      int orderPrice2 = 150;
      string orderDate2 = "02/27/2022";
      Order newOrder1 = new Order(orderTitle1, orderDescription1, orderPrice1, orderDate1);
      Order newOrder2 = new Order(orderTitle2, orderDescription2, orderPrice2, orderDate2);
      List<Order> newOrderList = new List<Order> { newOrder1, newOrder2 };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newOrderList, result);
    }

    [TestMethod]
    public void OrderId_AssignUniqueIdToOrder_Int()
    {
      Order newOrder = new Order("Bob's", "Red Mill", 50, "02/26/2022");

      int uniqueOrder = newOrder.OrderId;

      Assert.AreEqual(1, uniqueOrder);
    }
    
    public void Find_ReturnsOrderById_Order()
    {
      Order firstOrder = new Order("Weekly bread order", "25 loaves", 100, "02/14/2022");
      Order secondOrder = new Order("Weekly bread order", "50 loaves", 200, "02/21/2022");

      Order idSearch = Order.Find(2);

      Assert.AreEqual(2, idSearch);
    }
  }
}