using System;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
    public class PizzaShop
    {
        public Address Address {get; set;}
        public Dictionary<string, int> Inventory {get; set;}
        public List<Order> Orders {get; set;}

        //+ should be able to view its orders
        // - SQL

        //+ should be able to view its sales
        // - SQL?

        //+ should be able to view its inventory
        // - SQL

        //+ should be able to view its users
        // - SQL
    }
}