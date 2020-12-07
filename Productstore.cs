using System;
using System.Collections.Generic;
using System.Linq;


namespace LinqExample
{
    class Productstore
    {
        
            public string productName { get; set; }
            public int productPrice { get; set; }
        }

        class Program1
        {
            static void Main(string[] args)
            {
                
                
            List<Productstore> productList = new List<Productstore>();

                productList.Add(new Productstore { productName = "Hard Disk", productPrice = 1280 });
                productList.Add(new Productstore { productName = "Monitor", productPrice = 3000 });
                productList.Add(new Productstore { productName = "SSD Disk", productPrice = 3500 });
                productList.Add(new Productstore { productName = "RAM", productPrice = 2450 });
                productList.Add(new Productstore { productName = "Processor", productPrice = 7680 });
                productList.Add(new Productstore { productName = "Bluetooth", productPrice = 540 });
                productList.Add(new Productstore { productName = "Keyboard & Mouse", productPrice = 1130 });

                
                var result = from p in productList
                             orderby p.productPrice,p.productName
                             select p;

                
               // var result = productList.OrderBy(p =>p.productPrice);

                foreach ( var list in result)
                {
                    Console.WriteLine("Product Name: {0} | ProductPrice : {1}", list.productName, list.productPrice);
                }

                Console.ReadKey();
            }
        }
    }

