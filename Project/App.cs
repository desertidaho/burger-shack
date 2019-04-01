using System;
using Burgers.Project.Models;

namespace Burgers.Project
{
  class App
  {
    public Menu Menu { get; set; }
    public bool TakingOrder { get; set; }


    public void Start()
    {
      Console.Clear();
      while (TakingOrder)
      {
        if (Menu.Order.Count == 0)
        {
          Console.WriteLine("Would you like to order (F)ood, or a (D)rink?");
        }
        else
        {
          Console.WriteLine("Add (F)ood, a (D)rink, or (P)ay?");
        }
        string input = Console.ReadLine().ToLower();
        TypeOrder(input);
      }
    }

    void TypeOrder(string input)
    {
      switch (input)
      {
        case "f":
          Console.Clear();
          Menu.printFood();
          tallyFood();
          break;
        case "d":
          Console.Clear();
          Menu.printDrink();
          tallyDrink();
          break;
        case "p":
          Console.Clear();
          Menu.pay();
          Console.WriteLine("Will that be (C)ash, credi(t), or (B)itcoin?");
          Console.WriteLine("Thanks for paying, have a nice day.");
          TakingOrder = false;
          return;
        default:
          Console.WriteLine("Please enter an 'F', 'D', or 'C'");
          break;
      }
    }

    void tallyFood()
    {
      Console.Write(@"
Select an item number: ");
      Int32.TryParse(Console.ReadLine(), out int choice);
      int length = Menu.Entree.Count + Menu.Side.Count;
      if (choice > 0 && choice <= Menu.Entree.Count)
      {
        Menu.Order.Add(Menu.Entree[choice - 1]);
        Menu.printOrder();
      }
      else if (choice > Menu.Entree.Count && choice <= length)
      {
        Menu.Order.Add(Menu.Side[choice - (Menu.Entree.Count + 1)]);
        Menu.printOrder();
      }
      else
      {
        Console.WriteLine("Invalid Selection");
      }
    }

    void tallyDrink()
    {
      Console.Write(@"
Select an item number: ");
      Int32.TryParse(Console.ReadLine(), out int choice);
      int length = Menu.Fountain.Count + Menu.Shake.Count;
      if (choice > 0 && choice <= Menu.Fountain.Count)
      {
        Menu.Order.Add(Menu.Fountain[choice - 1]);
        Menu.printOrder();
      }
      else if (choice > Menu.Fountain.Count && choice <= length)
      {
        Menu.Order.Add(Menu.Shake[choice - (Menu.Fountain.Count + 1)]);
        Menu.printOrder();
      }
      else
      {
        Console.WriteLine("Invalid Selection");
      }
    }


    public App()
    {
      Menu = new Menu();
      TakingOrder = true;
    }
  }
}