using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BakeryVendors.Models;
using System;

namespace BakeryVendors.Tests
{
  [TestClass]
  public class VendorsTests
  {
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
  }
}