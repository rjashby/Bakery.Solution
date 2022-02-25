using System;
using System.Collections.Generic;
using System.Linq;

namespace Bakery.Models
{
  public class Bread
  {
    public int Quantity { get; }
    
    public Bread (int quantity)
    {
      Quantity = quantity;
    }

    // public int GetCost(int amount)
    // {
    //   return 0;
    // }
  }
  public class Pastry
  {
    public int Quantity { get; }
    
    public Pastry (int quantity)
    {
      Quantity = quantity;
    }

    // public int GetCost(int amount)
    // {
    //   return 0;
    // }
  }
}