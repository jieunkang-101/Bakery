using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry
  {
    public string Type {get; set;}
    public int Quantity {get; set;}
    public int Price { get; set; }

    public static string[] Types { get; } = {"Croissant" , "Apple Pie", "Strudel", "Mille-feuille"};
    public static List<Pastry> PastryList = new List<Pastry> {};
    public Pastry(int typeNumber, int quantity)
    {
      Type = Types[typeNumber-1];
      Quantity = quantity;
      PastryList.Add(this);
      Price = 0;
    }

    public static int TotalQty() 
    {
      int totalQty = 0;
      foreach (Pastry pastry in PastryList)
      {
        totalQty += pastry.Quantity;
      }
      return totalQty;
    }

    public void CaculatePastryPrice()
    {
      int QtyofPastry = Pastry.TotalQty();
      int freePastry = QtyofPastry / 3;
      Price += 5 * (QtyofPastry - freePastry);
    }
  }
}