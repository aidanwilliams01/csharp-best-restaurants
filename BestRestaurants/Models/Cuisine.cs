using System.Collections.Generic;
using System.Data.Common;
using System.Runtime.InteropServices;

namespace BestRestaurants.Models
{
  public class Cuisine
  {
    public string Description { get; set; }
    public int CuisineId { get; set; }
  
    public Cuisine(string description, int id)
    {
      Description = description;
      CuisineId = id;
    }
  }
}
