using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BakeryVendors.Models;
using System;

namespace BakeryVendors.Tests 
{
  [TestClass]
  public class VendorsTests : IDisposable
  {
    public void Dispose()
    {
      Vendors.ClearAll();
    }

    [TestMethod]
    public void Vendor_CreatesInstanceOfVendor_Vendors()
    {
      Vendors newVendor = new Vendors("name", "descriptopmn");
      Assert.AreEqual(typeof(Vendors), newVendor.GetType());

    }

    [TestMethod]
    public void GetVendorName_ReturnsVendorName_String()
    {
      string vendorName = "New Vendor";
      string vendorDescription = "stuff";
      Vendors newVendor = new Vendors(vendorName, vendorDescription);

      string testVendor = newVendor.VendorName;

      Assert.AreEqual(vendorName, testVendor);
    }

    [TestMethod]
    public void GetVendorDescription_ReturnsVendorDescription_String()
    {
      string vendorName = "New Vendor";
      string vendorDescription = "Details about new vendor";
      Vendors newVendor = new Vendors(vendorName, vendorDescription);
      Assert.AreEqual(vendorDescription, newVendor.VendorDescription);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_VendorsList()
    {
      List<Vendors> newList = new List<Vendors> { };
      List<Vendors> result = Vendors.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsListOfAddedVendors_VendorsList()
    {
      string vendorOne = "First Vendor";
      string vendorDescriptionOne = "Sells bread";
      string vendorTwo = "Second Vendor";
      string vendorDescriptionTwo = "Sells pastry";
      Vendors newVendor1 = new Vendors(vendorOne, vendorDescriptionOne);
      Vendors newVendor2 = new Vendors(vendorTwo, vendorDescriptionTwo);
      List<Vendors> newList = new List<Vendors> { newVendor1, newVendor2 };

      List<Vendors> result = Vendors.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void VendorId_AssignsUniqueIdToVendor_Int()
    {
      string vendorName = "New Vendor";
      string vendorDescription = "My first vendor";
      Vendors newVendor = new Vendors(vendorName, vendorDescription);

      int uniqueVendor = newVendor.VendorId;

      Assert.AreEqual(1, uniqueVendor);
    }

    [TestMethod]
    public void Find_ReturnsVendorById_Vendor()
    {
      string nameOne = "Old Vendor";
      string descriptionOne = "My first vendor";
      string nameTwo = "New Vendor";
      string descriptionTwo = "My latest vendor";
      Vendors oldVendor = new Vendors(nameOne, descriptionOne);
      Vendors newVendor = new Vendors(nameTwo, descriptionTwo);

      Vendors result = Vendors.Find(2);

      Assert.AreEqual(newVendor, result);
    }

    [TestMethod]
    public void AddOrder_LinkOrderToVendor_OrderList()
    {
    string orderTitle = "Weekly bread order";
    string orderDescription = "25 loaves";
    float orderPrice = 100;
    string orderDate = "02/26/2022";
    Order newOrder = new Order(orderTitle, orderDescription, orderPrice, orderDate);
    List<Order> newList = new List<Order> { newOrder };
    string vendorName = "Bob's Bakery";
    string vendorDescription = "Gluten free only";
    Vendors newVendor = new Vendors(vendorName, vendorDescription);
    newVendor.AddOrder(newOrder);

    List<Order> result = newVendor.Orders;

    CollectionAssert.AreEqual(newList, result);
    }
  }
}