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
      bread.Quantity = breadOrder;
      Console.WriteLine("How many pastries would you like to purchase today?");
      int pastryOrder = Convert.ToInt32(Console.ReadLine());
      pastry.Quantity = pastryOrder;
      Console.WriteLine($"The total cost for your {bread.Quantity} loaves of bread is ${bread.BreadAmount2(breadOrder)} dollars.");
      Console.WriteLine($"The total cost for your {pastry.Quantity} pastries is ${pastry.PastryAmount2(pastryOrder)} dollars.");
      Console.WriteLine($"Your grand total is ${bread.BreadAmount2(breadOrder) + pastry.PastryAmount2(pastryOrder)} dollars.");
    }
  }
}