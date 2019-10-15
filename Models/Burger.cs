using System;
using System.ComponentModel.DataAnnotations;

namespace burgercats.Models
{
  public class Burger
  {
    public Burger(string name, string description, double price)
    {
      this.Name = name;
      this.Description = description;
      this.Price = price;
    }

    public string Id { get; set; }
    [Required]
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }

  }
}