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
      Console.WriteLine("Bread Prices: \n A single loaf costs $5.00. \n But you can buy 2, and get the third free!");
      Console.WriteLine("Pastry Prices: \n A single pastry costs $2.00. \n But for every two pastries you buy, your next pastry is only $1.00!");
      Console.WriteLine("How many loaves of bread would you like to purchase today?");
      int breadOrder = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("How many pastries would you like to purchase today?");
      int pastryOrder = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine($"The total cost for your bread is ${bread.BreadAmount(breadOrder)} dollars.");
      Console.WriteLine($"And your pastry total is ${pastry.PastryAmount(pastryOrder)} dollars.");
      Console.WriteLine($"Your grand total is ${bread.BreadAmount(breadOrder) + pastry.PastryAmount(pastryOrder)} dollars.");
    }
  }
}