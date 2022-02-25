using System;
using System.Collections.Generic;
using System.Linq;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Bread bread = new Bread(0, 0);
      Pastry pastry = new Pastry(0, 0);
      Console.WriteLine("Welcome to Pete's Bakery");
      Console.WriteLine("Your Home for All Your Favorite Bread and Pastry");
      Console.WriteLine("How many loaves of bread would you like to purchase today?");
      int breadOrder = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("How many pastries would you like to purchase today?");
      int pastryOrder = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine($"The total cost of your bread is {bread.BreadAmount(breadOrder)}");
      Console.WriteLine($"And your pastry total is {pastry.PastryAmount(pastryOrder)}");
      Console.WriteLine($"Your grand total is {bread.BreadAmount(breadOrder) + pastry.PastryAmount(pastryOrder)}");
    }
  }
}