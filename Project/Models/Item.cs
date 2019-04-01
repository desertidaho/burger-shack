namespace Burgers.Project.Models
{
  abstract class Item
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }



    public Item(string name, string description, decimal price)
    {
      Name = name;
      Description = description;
      Price = price;
    }
  }
}