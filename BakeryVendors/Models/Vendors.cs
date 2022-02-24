using System.Collections.Generic;

namespace BakeryVendors.Models
{
  public class Vendors
  {
    public string VendorName { get; set; }
    public string VendorDescription { get; set; }

    public Vendors(string vendorName, string vendorDescription)
    {
      VendorName = vendorName;
      VendorDescription = vendorDescription;
    }
  }
}