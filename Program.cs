using System;
using Burgers.Project;

namespace Burgers
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      Console.WriteLine("Thanks for choosing Burger Shack.\nPress any key to view the menu.");
      Console.ReadKey();
      App app = new App();
      app.Start();
    }
  }
}
