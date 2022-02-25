using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bakery.Tests 
{
  [TestClass]
  public class Bread
  {
    [TestMethod]
    public void BreadConstructor_CreateInstanceOfBread_Bread()
    {
      Bread bread = new Bread();
      Assert.AreEqual(typeof(Bread), bread.GetType());
    }

    [TestClass]
    public class Pastry
    {
      [TestMethod]
      public void PastryConstructor_CreateInstanceOfPastry_Pastry()
      {
        Pastry Pastry = new Pastry();
        Assert.AreEqual(typeof(Pastry), Pastry.GetType());
      }
    }
  }
}