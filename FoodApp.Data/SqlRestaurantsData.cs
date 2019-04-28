using System;
using System.Collections.Generic;
using System.Text;
using FoodApp.Core;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace FoodApp.Data
{
    public class SqlRestaurantsData : IRestaurantData
    {
        private readonly ApplicationDbContext _dbContext;

        public SqlRestaurantsData(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Restaurant Add(Restaurant newRestaurant)
        {
            _dbContext.Add(newRestaurant);
            return newRestaurant;
        }

        public int Commit()
        {
            return _dbContext.SaveChanges();
        }

        public Restaurant Delete(int id)
        {//Changes wont be applied if we dont call Commit() method
            var restaurant = GetRestaurantById(id);
            if (restaurant != null)
            {
                _dbContext.Restaurants.Remove(restaurant);
            }
            return restaurant;
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _dbContext.Restaurants.OrderBy(r => r.Name);
        }

        public Restaurant GetRestaurantById(int restaurantId)
        {
            return _dbContext.Restaurants.Find(restaurantId);
        }

        public IEnumerable<Restaurant> GetRestaurantsByName(string name)
        {
            var query = from r in _dbContext.Restaurants
                        where r.Name.StartsWith(name) || string.IsNullOrEmpty(name)
                        orderby r.Name
                        select r;
            return query;
        }

        public Restaurant Update(Restaurant updatedRestaurant)
        {
            var entity = _dbContext.Restaurants.Attach(updatedRestaurant);
            entity.State = EntityState.Modified;
            return updatedRestaurant;
        }
    }
}
