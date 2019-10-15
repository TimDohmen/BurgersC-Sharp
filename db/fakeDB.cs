using System.Collections.Generic;
using burgercats.Models;

namespace burgercats.db
{
  public class fakeDB
  {
    public static List<Burger> Burgers = new List<Burger>(){
            new Burger("Big Bad Burger", "The Biggest Baddest Burger youve ever seen.", 17.99),
            new Burger("Small Boy Burger", "Not the biggest burger but definitely a burger nonetheless", 10.99),
            new Burger ("Green Borger", "Its green and maybe has meat", 5.96)
  };
  }
}