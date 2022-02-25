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
      Bread bread = new Bread(4);
      Assert.AreEqual(typeof(Bread), bread.GetType());
    }

    [TestMethod]
    public void GetQuantity_ReturnQuantity_Int()
    {
      int quantity = 4;
      Bread bread = new Bread(quantity);
      int result = bread.Quantity;
      Assert.AreEqual(quantity, result);
    }

    // [TestClass]
    // public class Pastry
    // {
    //   [TestMethod]
    //   public void PastryConstructor_CreateInstanceOfPastry_Pastry()
    //   {
    //     Pastry Pastry = new Pastry();
    //     Assert.AreEqual(typeof(Pastry), Pastry.GetType());
    //   }
    // }
  }
}