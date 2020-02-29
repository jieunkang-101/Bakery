using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread 
  {
    public string Type {get; set;}
    public int Quantity {get; set;}
    public int Price { get; set; }

    public static string[] Types { get; } = {"Sourdough" , "Brioche", "Baguette", "Rye"};
    public static List<Bread> BreadList = new List<Bread> {};
    public Bread(int typeNumber, int quantity)
    {
      Type = Types[typeNumber-1];
      Quantity = quantity;
      BreadList.Add(this);
    }

    public static int TotalQty() 
    {
      int totalQty = 0;
      foreach (Bread bread in BreadList)
      {
        totalQty += bread.Quantity;
      }
      return totalQty;
    }

    public static int CaculateBreadPrice()
    {
      int totalPrice = 0;
      int QtyofBread = Bread.TotalQty();
      int freeBread = QtyofBread / 3;
      totalPrice += 5 * (QtyofBread - freeBread);
      return totalPrice;
    }
  }
}