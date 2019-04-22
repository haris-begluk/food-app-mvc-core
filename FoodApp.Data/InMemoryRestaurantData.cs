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
                    new Restaurant{Id = 2,Name = "Neretva", Location = "Konjic",Cousine = CousineType.Bosnian},
                    new Restaurant{Id = 3,Name = "Nachos Mexico", Location = "Mexico City",Cousine = CousineType.Mexican},
                    new Restaurant{Id = 4,Name = "Mona Lisa", Location = "Oslo",Cousine = CousineType.Indian},
                };
            }
        public IEnumerable<Restaurant> GetAll()
        {

            return from r in restaurants
                   orderby r.Name
                   select r;

        }

        public Restaurant GetRestaurantById(int restaurantId)
        {
            return restaurants.SingleOrDefault(r => r.Id == restaurantId);
        }

        public IEnumerable<Restaurant>GetRestaurantsByName(string name = null)
        {
            return from r in restaurants
                   where string.IsNullOrEmpty(name)||r.Name.StartsWith(name)
                   orderby r.Name
                   select r;
        }
    }
}
 