using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread 
  {
    public string Type {get; set;}
    public int Quantity {get; set;}
    public static string[] Types { get; } = {"Sourdough" , "Brioche", "Baguette", "Rye"};
    private static List<Bread> _breadOrderList = new List<Bread> {};
    public static int TotalPrice {get; set;}

    public Bread(int typeNumber, int quantity)
    {
      Type = Types[typeNumber-1];
      Quantity = quantity;
      _breadOrderList.Add(this);
      TotalPrice = 0;
    }

    public static List<Bread> GetBreadList()
    {
      return _breadOrderList;
    }

    public static int GetTotalQty()
    {
      return TotalQty();
    }

    private static int TotalQty() 
    {
      int totalQty = 0;
      foreach (Bread bread in _breadOrderList)
      {
        totalQty += bread.Quantity;
      }
      return totalQty;
    }

    public static int GetBreadPrice()
    {
      return CaculateBreadPrice();
    }
    
    private static int CaculateBreadPrice()
    {
      //totalPrice = 0;
      int qtyOfBread = TotalQty();
      int freeBread = qtyOfBread / 3;
      Bread.TotalPrice += 5 * (qtyOfBread - freeBread);
      return Bread.TotalPrice;
    }
  }
}
