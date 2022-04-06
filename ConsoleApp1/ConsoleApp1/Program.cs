using ConsoleApp1.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
    

        static void Main(string[] args)
        {

            Product Watch = new Product { Id = 1, Name = "Rolex", Price = 350.50 };
            Product Silver = new Product { Id = 2, Name = "SilverBaku", Price = 140.25 };
            Product Parfum = new Product { Id = 3, Name = "KasibinParfumu",Price = 0.50 };
            Orderitem item1 = new Orderitem { Id = 1, Product = Watch, Count = 2, TotalPrice = Watch.Price * 2 };
            Orderitem item2 = new Orderitem { Id = 2, Product = Silver, Count = 4, TotalPrice = Silver.Price * 4 };
            Orderitem item3 = new Orderitem { Id = 3, Product = Parfum, Count = 7, TotalPrice = Parfum.Price * 7 };
            Orderitem item4 = new Orderitem { Id = 4, Product = Silver, Count = 1, TotalPrice = Watch.Price * 1 };
            List<OrderItem> orderItems1 = new List<OrderItem>(); 
            orderItems1.Add(item1);
            orderItems1.Add(item3);
            List<OrderItem> orderItems2 = new List<OrderItem>();
            orderItems2.Add(item2);
            orderItems2.Add(item4);
            Order order1 = new Order { Id = 1, OrderItems = orderItems1 };
            Order order2 = new Order { Id = 2, OrderItems = orderItems2};
            var jsonObj = JsonConvert.SerializeObject(order1);
            Console.WriteLine(jsonObj);
            using (StreamWriter sw = new StreamWriter(@"C:/c/Users/windows/Desktop/New folder (2)/json1.json"))
            {
                sw.WriteLine(jsonObj);
            }

        }
    }
}
