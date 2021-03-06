using ConsoleApp1.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        private static object sm;

        static void Main(string[] args)

        {

            //Product Watch = new Product { Id = 1, Name = "Rolex", Price = 350.50 };
            //Product Silver = new Product { Id = 2, Name = "SilverBaku", Price = 140.25 };
            //Product Parfum = new Product { Id = 3, Name = "KasibinParfumu",Price = 0.50 };
            //Orderitem item1 = new Orderitem { Id = 1, Product = Watch, Count = 2, TotalPrice = Watch.Price * 2 };
            //Orderitem item2 = new Orderitem { Id = 2, Product = Silver, Count = 4, TotalPrice = Silver.Price * 4 };
            //Orderitem item3 = new Orderitem { Id = 3, Product = Parfum, Count = 7, TotalPrice = Parfum.Price * 7 };
            //Orderitem item4 = new Orderitem { Id = 4, Product = Silver, Count = 1, TotalPrice = Watch.Price * 1 };
            //List<Orderitem> orderItems1 = new List<Orderitem>();
            //orderItems1.Add(item1);
            //orderItems1.Add(item3);
            //List<Orderitem> orderItems2 = new List<Orderitem>();
            //orderItems2.Add(item2);
            //orderItems2.Add(item4);
            //Order order1 = new Order { Id = 1, OrderItems = orderItems1 };
            //Order order2 = new Order { Id = 2, OrderItems = orderItems2 };
            //var jsonObj = JsonConvert.SerializeObject(order1);
            //Console.WriteLine(jsonObj);
            //using (StreamWriter sw = new StreamWriter(@"C:\Users\tu7bg7w6d\Desktop\New folder\ConsoleApp1\ConsoleApp1\File\json1.json"))
            //{
            //    sw.WriteLine(jsonObj);
            //}
            string result;
            using (StreamReader sm = new StreamReader(@"C:\Users\tu7bg7w6d\Desktop\New folder\ConsoleApp1\ConsoleApp1\File\Product.json"))
            {
                result = sm.ReadToEnd();
            }
            Order order = JsonConvert.DeserializeObject<Order>(result);
            foreach (var item in order.OrderItems)
            {
                Console.WriteLine($@"Id: {item.Product.Id} | Name: {item.Product.Name} | Count: {item.Count} | Total Price: {item.TotalPrice}");
            }

        }
    }
}
