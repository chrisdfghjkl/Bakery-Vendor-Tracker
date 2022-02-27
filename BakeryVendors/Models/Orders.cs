using System.Collections.Generic;
using System;

namespace BakeryVendors.Models
{
  public class Order
  {
    private static List<Order> _orderInstances = new List<Order> {};
    public string OrderTitle { get; set;}
    public string OrderDescription { get; set; }
    public float OrderPrice { get; set; }
    public string OrderDate { get; set; }
    public int OrderId { get; }
    public Order(string orderTitle, string orderDescription, float orderPrice, string orderDate)
    {
      OrderTitle = orderTitle;
      OrderDescription = orderDescription;
      OrderPrice = orderPrice;
      OrderDate = orderDate;
      _orderInstances.Add(this);
      OrderId = _orderInstances.Count;
    }

    public static List<Order> GetAll()
    {
      return _orderInstances;
    }

    public static Order Find(int searchId)
    {
      return _orderInstances[searchId-1];
    }
    public static void ClearAll()
    {
      _orderInstances.Clear();
    }
  }
}