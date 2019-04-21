using FoodApp.Core;
using System.Collections.Generic;
using System.Linq;

namespace FoodApp.Data
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
                {
                    new Restaurant{Id = 1,Name = "Megrate Pizza", Location = "London",Cousine = CousineType.Italian},
                    new Restaurant{Id = 1,Name = "Neretva", Location = "Konjic",Cousine = CousineType.Bosnian},
                    new Restaurant{Id = 1,Name = "Nachos Mexico", Location = "Mexico City",Cousine = CousineType.Mexican},
                    new Restaurant{Id = 1,Name = "Mona Lisa", Location = "Oslo",Cousine = CousineType.Indian},
                };
            }
        public IEnumerable<Restaurant> GetAll()
        {

            return from r in restaurants
                   orderby r.Name
                   select r;

        }
    }
}
 