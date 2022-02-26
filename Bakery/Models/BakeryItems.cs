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
      Bread bread = new Bread(0, 0);
      bread.Quantity = amount;
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
          Console.WriteLine("Limit of 3 loaves per customer.");
          break;
          }
      return bread.Cost;
    }

    public List<int> OrderList(int num)
    {
      List<int> Count = new List<int>();
      for (int i = 0; i <= num; i++) 
      {
      Count.Add(i);
      }
      return Count;
    }

    public int BreadAmount2(int amount)
    {
      Bread bread = new Bread(0, 0);
      bread.Quantity = amount;
      List<int> breadList = bread.OrderList(amount);
      foreach(int num in breadList)
      {
        if (num == 0)
        {
          bread.Cost += 0;
        }
        else if (num % 3 != 0)
        {
          bread.Cost += 5;
        } 
        else
        {
          bread.Cost += 0;
        }
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
      Pastry pastry = new Pastry(0, 0);
      pastry.Quantity = amount;
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
          Console.WriteLine("Limit of 6 pastries per customer.");
          break;
          }
      return pastry.Cost;
    }

    public List<int> OrderList(int num)
    {
      List<int> Count = new List<int>();
      for (int i = 0; i <= num; i++) 
      {
      Count.Add(i);
      }
      return Count;
    }
    public int PastryAmount2(int amount)
    {
      Pastry pastry = new Pastry(0, 0);
      pastry.Quantity = amount;
      List<int> pastryList = pastry.OrderList(amount);
      foreach(int num in pastryList)
      {
        if (num == 0)
        {
          pastry.Cost += 0;
        }
        else if (num % 3 != 0)
        {
          pastry.Cost += 2;
        } 
        else
        {
          pastry.Cost += 1;
        }
      }
      return pastry.Cost;
    }
  }
}