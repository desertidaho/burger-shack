using System;
using System.Collections.Generic;

namespace Burgers.Project.Models
{
  class Menu
  {
    public List<Entree> Entree { get; set; }
    public List<Side> Side { get; set; }
    public List<Fountain> Fountain { get; set; }
    public List<Shake> Shake { get; set; }
    public List<Item> Order { get; set; }

    public void printFood()
    {
      Console.WriteLine("Entrees:");
      for (var i = 0; i < Entree.Count; i++)
      {
        var e = Entree[i];
        Console.WriteLine($"{i + 1}. {e.Name} ${e.Price}");
      }
      Console.WriteLine(@"
Sides:");
      for (var i = 0; i < Side.Count; i++)
      {
        var s = Side[i];
        Console.WriteLine($"{Entree.Count + i + 1}. {s.Name} ${s.Price}");
      }
    }

    public void printDrink()
    {
      Console.WriteLine("Fountain:");
      for (var i = 0; i < Fountain.Count; i++)
      {
        var f = Fountain[i];
        Console.WriteLine($"{i + 1}. {f.Name} ${f.Price}");
      }
      Console.WriteLine(@"
Shakes:");
      for (var i = 0; i < Shake.Count; i++)
      {
        var s = Shake[i];
        Console.WriteLine($"{Fountain.Count + i + 1}. {s.Name} ${s.Price}");
      }
    }

    public void printOrder()
    {
      Console.Clear();
      Console.WriteLine("Your order:");
      for (var i = 0; i < Order.Count; i++)
      {
        var o = Order[i];
        Console.WriteLine($"{i + 1}. {o.Name} ${o.Price}");
      }
    }

    public void pay()
    {
      decimal total = 0;
      for (var i = 0; i < Order.Count; i++)
      {
        total += Order[i].Price;
      }
      decimal tax = 1.06m;
      total *= tax;
      Console.WriteLine($"Your total is {total}");
    }


    public Menu()
    {
      Entree = new List<Entree>()
      {
        new Entree("Burger", "Delicious, tasty hamburger.", 6.99m ),
        new Entree("Cheeseburger", "Delicious, tasty hamburger with cheese.", 7.99m ),
        new Entree("Bacon Burger", "Delicious, tasty hamburger with bacon.", 8.99m ),
        new Entree("Bacon Cheeseburger", "Delicious, tasty hamburger with bacon and cheese.", 9.99m )
    };

      Side = new List<Side>()
      {
        new Side("Small French Fry", "Delicious deep fried potatoes.", 0.99m ),
        new Side("Medium French Fry", "Delicious deep fried potatoes.", 1.99m ),
        new Side("Large French Fry", "Delicious deep fried potatoes.", 2.99m ),
        new Side("Onion Rings", "Delicious deep fried onions.", 2.99m )
    };

      Fountain = new List<Fountain>()
      {
        new Fountain("Pepsi", "Delicious cola.", 0.99m ),
        new Fountain("Coke", "Delicious cola.", 0.99m ),
        new Fountain("Tab", "Delicious cola.", 0.99m )
    };

      Shake = new List<Shake>()
      {
        new Shake("Vanilla", "Delicious frozen milk.", 3.99m ),
        new Shake("Strawberry", "Delicious frozen milk.", 3.99m ),
        new Shake("Chocolate", "Delicious frozen milk.", 3.99m ),
    };

      Order = new List<Item>() { };
    }
  }
}