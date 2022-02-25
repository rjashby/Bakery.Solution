using System;
using System.Collections.Generic;
using System.Linq;

namespace Bakery.Models
{
 public class Bread
  {
    public int BreadCost { get; set ;}
    
    public Bread(int breadCost)
    {
      BreadCost = breadCost;
    }
  }
  public class Pastry
  {
    public int PastryCost { get; set ;}
    
    public Pastry(int pastryCost)
    {
      PastryCost = pastryCost;
    }
  }
}