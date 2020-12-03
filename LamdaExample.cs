﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqExample
{
    class LamdaExample
{
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() {36, 71, 12,
                             15, 29, 18, 27, 17, 9, 34};

        // foreach loop to dislay the list 
        Console.Write("The list : "); 
        foreach(var value in numbers) 
        { 
            Console.Write("{0} ", value); 
        }
    Console.WriteLine(); 
  
        // Using lambda expression 
        // to calculate square of 
        // each value in the list 
        var square = numbers.Select(x => x * x);

    // foreach loop to display squares 
    Console.Write("Squares : "); 
        foreach(var value in square) 
        { 
            Console.Write("{0} ", value); 
        }
Console.WriteLine(); 
  
        // Using Lambda exression to 
        // find all numbers in the list 
        // divisible by 3 
        List<int> divBy3 = numbers.FindAll(x => (x % 3) == 0); 
  
        // foreach loop to display divBy3 
        foreach(var value in divBy3) 
        { 
            Console.Write("{0} ", value); 
        } 
        Console.WriteLine(); 
    } 
} 
} 
    

