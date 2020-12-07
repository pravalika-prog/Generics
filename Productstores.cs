using System;
using System.Collections.Generic;
using System.Linq;


namespace LinqExample
{
    class Productstores
    {
        
            public string productName { get; set; }
            public int productPrice { get; set; }
        }

        class Program3
        {
            static void Main(string[] args)
            {
               
                List<Productstores> productList = new List<Productstores>();

                productList.Add(new Productstores { productName = "Hard Disk", productPrice = 1280 });
                productList.Add(new Productstores { productName = "Monitor", productPrice = 3000 });
                productList.Add(new Productstores { productName = "Monitor", productPrice = 3500 });
                productList.Add(new Productstores { productName = "Monitor", productPrice = 2000 });
                productList.Add(new Productstores { productName = "SSD Disk", productPrice = 3500 });
                productList.Add(new Productstores { productName = "RAM", productPrice = 2450 });
                productList.Add(new Productstores { productName = "Processor", productPrice = 7680 });
                productList.Add(new Productstores { productName = "Bluetooth", productPrice = 540 });
                productList.Add(new Productstores { productName = "Keyboard & Mouse", productPrice = 1130 });

                var result = productList.OrderBy(p => p.productName).ThenBy(p => p.productPrice);

                foreach (var list in result) { 
                    Console.WriteLine("Product Name: {0} | Product Price : {1}", list.productName, list.productPrice);
            }

            Console.ReadKey();
        }
    }
}
