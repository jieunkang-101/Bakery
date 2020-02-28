using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      DisplayWelcome();
      MainMenu();
      PlaceOrder();
    }

    public static void DisplayWelcome()
    {
      Console.Clear();
      Console.WriteLine(@"
      _______   _                               _         ______           __                            
      |_   _ \ (_)                             | |       |_   _ \         [  |  _                        
      | |__) |__  .---.  _ .--.  _ .--.  .---.\_|.--.     | |_) |  ,--.   | | / ] .---.  _ .--.  _   __ 
      |  ___/[  |/ /__\\[ `/'`\][ `/'`\]/ /__\\ ( (`\]    |  __'. `'_\ :  | '' < / /__\\[ `/'`\][ \ [  ]
     _| |_    | || \__., | |     | |    | \__.,  `'.'.   _| |__) |// | |, | |`\ \| \__., | |     \ '/ / 
    |_____|  [___]'.__.'[___]   [___]    '.__.' [\__) ) |_______/ \'-;__/[__|  \_]'.__.'[___]  [\_:  /  
                                                                                                \__.'   
      ");
      Console.WriteLine("\n--------- Welcome to Pierre's Bakery -----------\n");
      Console.WriteLine("Bread: $5    Special Deal: Buy 2, get 1 free \n");
      Console.WriteLine("Pastry: $2   Special Deal: 3 for $5\n");
      Console.WriteLine("------------------------------------------------\n");
      Console.Write("Press any key to continue");
      Console.ReadKey();
    }

    public static void MainMenu()
    {
      Console.Clear();
      Console.WriteLine("\n--------- Main Menu ----------");
      Console.WriteLine("Enter 'B' to view Bread Menu");
      Console.WriteLine("Enter 'P' to view Pastry Menu");
      Console.WriteLine("Enter 'V' to View Order Status");
      Console.WriteLine("-------------------------------\n");
      string mainInput = Console.ReadLine();
      if ( mainInput == "B" || mainInput =="b")
      {
        BreadMenu();
      }
      else if ( mainInput == "P" || mainInput =="p")
      {
        PastryMenu();
      }
      else if ( mainInput == "V" || mainInput =="v")
      {
        OrderStatus();
      }
      else 
      {
        Console.WriteLine("Please enter B, P or V");
        MainMenu();
      }
    }

    public static void BreadMenu()
    {
      Console.Clear();
      Console.WriteLine("\n--------- Bread Menu --------");

      for (int i = 0; i < Bread.Types.Length; i++)
      {
          Console.WriteLine($"{i+1}: {Bread.Types[i]}");
      }

      Console.WriteLine("----------------------------------------\n"); 
      Console.Write("Enter a number of bread to order: ");
      int typeNumber = int.Parse(Console.ReadLine());
      Console.Write("Enter a number of loaves to add your order: ");
      int quantity = int.Parse(Console.ReadLine());
      Bread newBread = new Bread(typeNumber, quantity);
      showBreadOrder();
      Console.WriteLine("\n-------------------------------------------\n"); 
      Console.WriteLine("Would you like to add more bread? [Y or N]");
      string addBread = Console.ReadLine();

      if (addBread == "Y" || addBread == "y")
      {
        BreadMenu();
      }
      else if (addBread == "N" || addBread == "n")
      {
        MainMenu();
      }
    }
    public static void showBreadOrder()
    {
      foreach (Bread breadOrder in Bread.BreadList)
      {
        Console.WriteLine($"\n Added {breadOrder.Quantity} loaves of {breadOrder.Type} to your order.");
      }
    }
    public static void PastryMenu()
    {
      
    }

    public static void OrderStatus()
    {
      
    }

    public static void PlaceOrder()
    {

    }
  }
}      