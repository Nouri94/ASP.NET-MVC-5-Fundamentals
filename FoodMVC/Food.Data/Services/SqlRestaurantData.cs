using Food.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food.Data.Services
{
    public class SqlRestaurantData : IRestaurantData
    {
        private readonly FoodDbContext _db;
        public SqlRestaurantData(FoodDbContext db)
        {
            this._db = db;
        }

        public void Add(Restaurant restaurant)
        {
            _db.Restaurants.Add(restaurant);
            _db.SaveChanges();
        }

        public void Update(Restaurant restaurant)
        {
            var entry = _db.Entry(restaurant);
            entry.State = EntityState.Modified;
            _db.SaveChanges();

        }

        public Restaurant Get(int id)
        {
            return _db.Restaurants.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _db.Restaurants;
        }

        public void Delete(int id)
        {
            var restaurant = _db.Restaurants.Find(id);
            _db.Restaurants.Remove(restaurant);
            _db.SaveChanges();
        }
    }
}
