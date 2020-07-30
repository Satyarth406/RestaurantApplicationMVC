using System.Collections.Generic;
using RestaurantApplication.Models;

namespace RestaurantApplicationMVC.Repository
{
    public interface IRestaurantRepository
    {
        List<Restaurant> AllRestaurants();
        Restaurant GetRestaurantById(int id);
        Restaurant UpdateRestaurant(Restaurant updatedRestaurant);
        Restaurant CreateRestaurant(Restaurant newRestaurant);
        void DeleteRestaurant(int id);
    }
}
