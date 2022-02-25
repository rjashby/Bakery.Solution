using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bakery.Tests 
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreateInstanceOfBread_Bread()
    {
      Bread bread = new Bread(4, 7);
      Assert.AreEqual(typeof(Bread), bread.GetType());
    }

    [TestMethod]
    public void GetQuantity_ReturnQuantity_Int()
    {
      int quantity = 4;
      int cost = 7;
      Bread bread = new Bread(quantity, cost);
      int result = bread.Quantity;
      Assert.AreEqual(quantity, result);
    }

    [TestMethod]
    public void GetCost_ReturnCost_Int()
    {
      int quantity = 4;
      int cost = 7;
      Bread bread = new Bread(quantity, cost);
      int result = bread.Cost;
      Assert.AreEqual(cost, result);
    }

    // [TestMethod]
    // public void GetCost_ReturnCost_Int()
    // {
    //   int amount = 4;
    //   Bread bread = new Bread(quantity);
    //   int result = bread.Quantity;
    //   Assert.AreEqual(quantity, result);
    // }
  }

  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreateInstanceOfPastry_Pastry()
    {
      Pastry pastry = new Pastry(4);
      Assert.AreEqual(typeof(Pastry), pastry.GetType());
    }

    [TestMethod]
    public void GetQuantity_ReturnQuantity_Int()
    {
      int quantity = 2;
      Pastry pastry = new Pastry(quantity);
      int result = pastry.Quantity;
      Assert.AreEqual(quantity, result);
    }
  }
}