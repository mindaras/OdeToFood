﻿using System;
using System.Collections.Generic;
using System.Linq;
using OdeToFood.Models;
using OdeToFood.ViewModels;

namespace OdeToFood.Services
{
    //public class InMemoryRestaurantData : IRestaurantData
    //{
    //    List<Restaurant> _restaurants;

    //    public InMemoryRestaurantData()
    //    {
    //        _restaurants = new List<Restaurant>
    //        {
    //            new Restaurant {Id = 1, Name =  "Scott's Pizza Place"},
    //            new Restaurant {Id = 2, Name = "Tersiguels"},
    //            new Restaurant {Id = 3, Name = "King's Contrivance"}
    //        };
    //    }

    //    public IEnumerable<Restaurant> GetAll()
    //    {
    //        return _restaurants.OrderBy(r => r.Name);
    //    }

    //    public Restaurant Get(int id)
    //    {
    //        return _restaurants.FirstOrDefault(r => r.Id == id);
    //    }

    //    public Restaurant Add(Restaurant restaurant)
    //    {
    //        restaurant.Id = _restaurants.Max(r => r.Id) + 1;
    //        _restaurants.Add(restaurant);

    //        return restaurant;
    //    }
    //}
}