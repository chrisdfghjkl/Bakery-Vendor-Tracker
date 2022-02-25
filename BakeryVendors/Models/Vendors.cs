using System.Collections.Generic;

namespace BakeryVendors.Models
{
  public class Vendors
  {
    public string VendorName { get; set; }
    public string VendorDescription { get; set; }
    private static List<Vendors> _instances = new List<Vendors> { };

    public Vendors(string vendorName, string vendorDescription)
    {
      VendorName = vendorName;
      VendorDescription = vendorDescription;
    }

    public static List<Vendors> GetAll()
    {
      return _instances;
    }

  }
}