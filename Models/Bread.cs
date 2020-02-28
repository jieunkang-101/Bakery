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

    // public Bread()
    // {
    
    // }

    // public void CaculateBreadPrice()
    // {

    // }
  }
}