using System.Collections.Generic;
using System.Data.Common;
using System.Runtime.InteropServices;

namespace BestRestaurants.Models
{
  public class Cuisine
  {
    public string Name { get; set; }
    public int CuisineId { get; set; }
    public List<Restaurant> Restaurants {get; set; }
  }
}