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
      Vendors newVendor = new Vendors("name");
      Assert.AreEqual(typeof(Vendors), newVendor.GetType());

    }

    [TestMethod]
    public void GetVendorName_ReturnsVendorName_String()
    {
      string vendorName = "New Vendor";
      Vendors newVendor = new Vendors(vendorName);

      string testVendor = newVendor.VendorName;

      Assert.AreEqual(vendorName, testVendor);
    }
  }
}