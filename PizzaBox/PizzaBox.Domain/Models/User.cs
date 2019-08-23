using System;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
    public class User
    {
        public string Name {get; set;}
        public List<Order> Orders {get; set;}
        public PizzaShop Recent {get; set;}

        //+ should be able to view its order history
        // - SQL

        //+ should be able to only order from 1 location/day

        //+ should be able to only order 1 time within a 2 hour period

        //+ should be able to only order if an account exists
        // - SQL
    }
}