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
        case 0:
          bread.Cost = 0;
          break;
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
      switch(amount) 
      {
        case 0:
          pastry.Cost = 0;
          break;
        case 1:
          pastry.Cost = amount * 2;
          break;
        case 2:
          pastry.Cost = amount * 2;
          break;
        case 3:
          pastry.Cost = 5;
          break;  
        case 4:
          pastry.Cost = (amount * 2) - 1;
          break;  
        case 5:
          pastry.Cost = (amount * 2) - 1;
          break;  
        case 6:
          pastry.Cost = 10;
          break;    
        default:
          Console.WriteLine("Limit of 6 pastries per customer");
          break;
          }
      return pastry.Cost;
    }
  }
}