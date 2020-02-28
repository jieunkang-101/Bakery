using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public string Type { get; set; }
    public string[] Types { get; } = {"Sourdough" , "Brioche", "Baguette", "Rye"};
    public static List<Bread> BreadList = new List<Bread> {};
    public int Quantity { get; set; }
    public int Price { get; set; }

    public Bread(int typeNumber, int quantity)
    {
      Type = Types[typeNumber];
      Quantity = quantity;
      BreadList.Add(this);
      Price = 0;
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

    public void CaculateBreadPrice()
    {
      int QtyofBread = Bread.TotalQty();
      int freeBread = QtyofBread / 3;
      Price += 5 * (QtyofBread - freeBread);
    }
  }
}