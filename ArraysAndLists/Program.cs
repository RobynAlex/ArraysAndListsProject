﻿using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // Create two Lists of type int.
            // Name one List "evens"
            var evens = new List<int>();
            var odds = new List<int>();

            
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        evens.Add(numbers[i]);
                    }
                    else
                    {
                    odds.Add(numbers[i]);
                    }
               
                }


            // Name the other List "odds"
            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */

            foreach (var evenNum in evens)
                {
                Console.WriteLine($"{evenNum} is an even number!");
                }

            foreach (var oddNum in odds)
            {
                Console.WriteLine($"{oddNum} is an odd number!");
            }


        }
    }
}
