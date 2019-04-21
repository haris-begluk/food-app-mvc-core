using FoodApp.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodApp.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }
}
 