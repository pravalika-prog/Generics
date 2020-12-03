using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> my_list = new List<string>()
        {
                "This is my Dog",
                "Name of my Dog is Robin",
                "This is my Cat",
                "Name of the cat is Mewmew"
        };

            
            var res = from p in my_list
                      where p.Contains("my")
                      select p;

            
            foreach (var q in res)
            {
                Console.WriteLine(q);
            }
            List<string> my_list1 = new List<string>() {
                "This is my Dog",
                "Name of my Dog is Robin",
                "This is my Cat",
                "Name of the cat is Mewmew"
        };

           
            var res1 = my_list1.Where(a =>
            
            a.Contains("Dog"));

            
            foreach (var q1 in res1)
            {
                Console.WriteLine(q1);
            }
        }
    }
    
        }


   
    

