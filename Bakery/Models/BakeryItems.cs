using System;
using System.Collections.Generic;
using System.Linq;

namespace Bakery.Models
{
  public class Bread
  {
    public int Quantity { get; set; }
    public int Cost { get; set; }
    
    public Bread (int quantity, int cost)
    {
      Quantity = quantity;
      Cost = cost;
    }

    public int BreadAmount(int amount)
    {
      Bread bread = new Bread(4, 0);
      switch(amount) 
      {
        case 1:
          bread.Cost = amount * 5;
          break;
        case 2:
          bread.Cost = amount * 5;
          break;
        case 3:
          bread.Cost = (amount * 5) - 5;
          break;  
        default:
          Console.WriteLine("Limit of 3 loaves per customer");
          break;
          }
      return bread.Cost;
    }
  }
  public class Pastry
  {
    public int Quantity { get; set; }
    public int Cost { get; set; }
    
    public Pastry (int quantity, int cost)
    {
      Quantity = quantity;
      Cost = cost;
    }
    public int PastryAmount(int amount)
    {
      Pastry pastry = new Pastry(4, 0);
      pastry.Cost = amount * 2;
      return pastry.Cost;
    }
    // public int GetCost(int amount)
    // {
    //   return 0;
    // }
  }
}