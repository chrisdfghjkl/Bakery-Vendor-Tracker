using System.Collections.Generic;
using System;

namespace BakeryVendors.Models
{
  public class Order
  {
    private static List<Order> _orderInstances = new List<Order> {};
    public string OrderTitle { get; set;}
    public string OrderDescription { get; set; }
    public int OrderPrice { get; set; }
    public Order(string orderTitle, string orderDescription, int orderPrice)
    {
      OrderTitle = orderTitle;
      OrderDescription = orderDescription;
      OrderPrice = orderPrice;
      _orderInstances.Add(this);
    }
    public static void ClearAll()
    {
      _orderInstances.Clear();
    }
  }
}