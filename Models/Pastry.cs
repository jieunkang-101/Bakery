using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry
  {
    public string Type {get; set;}
    public int Quantity {get; set;}
    public static string[] Types { get; } = {"Croissant" , "Apple Pie", "Strudel", "Mille-feuille"};
    private static List<Pastry> _pastryOrderList = new List<Pastry> {};

    public Pastry(int typeNumber, int quantity)
    {
      Type = Types[typeNumber-1];
      Quantity = quantity;
      _pastryOrderList.Add(this);
    }

    public static List<Pastry> GetPastryList()
    {
      return _pastryOrderList;
    }

    public static int GetTotalQty()
    {
      return TotalQty();
    }

    private static int TotalQty() 
    {
      int totalQty = 0;
      foreach (Pastry pastry in _pastryOrderList)
      {
        totalQty += pastry.Quantity;
      }
      return totalQty;
    }

    public static int GetPastryPrice()
    {
      return CaculatePastryPrice();
    }
    
    private static int CaculatePastryPrice()
    {
      int totalPrice = 0;
      int qtyOfPastry = TotalQty();
      totalPrice += (qtyOfPastry * 2) - (qtyOfPastry /3);
      return totalPrice;
    }
  }
}
