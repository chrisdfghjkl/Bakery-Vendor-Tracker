using System.Collections.Generic;
using System;

namespace BakeryVendors.Models
{
  public class Order
  {
    public string OrderTitle { get; set;}
    public Order(string orderTitle)
    {
      OrderTitle = orderTitle;
    }
  }
}