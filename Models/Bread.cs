using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread 
  {
    public string Type {get; set;}
    public int Quantity {get; set;}
    //public int Price { get; set; }
    public static string[] Types { get; } = {"Sourdough" , "Brioche", "Baguette", "Rye"};
    private static List<Bread> _breadOrderList = new List<Bread> {};

    public Bread(int typeNumber, int quantity)
    {
      Type = Types[typeNumber-1];
      Quantity = quantity;
      _breadOrderList.Add(this);
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
      int totalPrice = 0;
      int QtyOfBread = Bread.TotalQty();
      int freeBread = QtyOfBread / 3;
      totalPrice += 5 * (QtyOfBread - freeBread);
      return totalPrice;
    }
  }
}