using System;
using System.Collections.Generic;
using System.Linq;

namespace Bakery.Models
{
  public class Bread
  {
    public int Quantity { get; }
    public int Cost { get; }
    
    public Bread (int quantity, int cost)
    {
      Quantity = quantity;
      Cost = cost;
    }

    public int BreadAmount(int amount)
    {
      return 0;
    }
  }
  public class Pastry
  {
    public int Quantity { get; }
    public int Cost { get; }
    
    public Pastry (int quantity, int cost)
    {
      Quantity = quantity;
      Cost = cost;
    }

    // public int GetCost(int amount)
    // {
    //   return 0;
    // }
  }
}