using System;

namespace burgercats.Models
{
  public class Burger
  {
    public Burger(string name, string description, int price)
    {
      Id = Guid.NewGuid().ToString();
      Name = name;
      Description = description;
      Price = price;
    }

    public string Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }

  }
}