using System.Collections.Generic;

namespace BakeryVendors.Models
{
  public class Vendors
  {
    public string VendorName { get; set; }
    public string VendorDescription { get; set; }
    public int VendorId { get; }
    private static List<Vendors> _instances = new List<Vendors> { };

    public Vendors(string vendorName, string vendorDescription)
    {
      VendorName = vendorName;
      VendorDescription = vendorDescription;
      _instances.Add(this);
      VendorId = _instances.Count;
    }

    public static List<Vendors> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}