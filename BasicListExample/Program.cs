using System;
using System.Collections.Generic;

namespace BasicListExample
{
    class Program
    {

        static void Main(string[] args)
        {
            // WorkingWithStrings();
            WorkingWithNumbers();
        }



        public static void WorkingWithNumbers()
        {
            // this creates a list of integers, and sets the first two integers to the value 1
            var fibonacciNumbers = new List<int> { 1, 1 };

          
            while (fibonacciNumbers.Count < 20)
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                // each next Fibonacci number is found by taking the sum of the previous two numbers
                fibonacciNumbers.Add(previous + previous2);
            }

            // display to the console
            foreach (var item in fibonacciNumbers)
            {
                Console.WriteLine(item);
            }


        }


        public static void WorkingWithStrings()
        {
            // the collection below uses the List<T> type.
            // this type stores sequences of elements.  
            // You specify the type of the elements between the angle brackets.
            // One important apsect of the List<T> type is that it can grow or shrink, enabling you to add or remove elements.

            var names = new List<string>
            {
                "Squanchy", "Squancho", "Arthur"
            };

            // add two more names to the List and remove one.
            Console.WriteLine();
            names.Add("Bill");
            names.Add("Micah");
            names.Remove("Squancho");


            foreach (var name in names)
            {
                // String interpolation: when you precede a string with the $ character, you can embed
                // C# code in the string declaration.  The actual string replaces the C# code with the value
                // it generates.  
                Console.WriteLine($" Hello {name.ToUpper()}!");
            }


            // the List<T> enables you to reference individual items by index as well.
            // You place the index between [] tokens following the list name.
            Console.WriteLine($"\nMy name is {names[0]}");


            // you can check how long the list is using the Count property
            Console.WriteLine($"\nThe list has {names.Count} people in it");



            // the IndexOf method searches for an item and returns the index of the item
            var index = names.IndexOf("Squanchy");
            if (index == -1)
            {
                Console.WriteLine($"\nWhen an item is not found, IndexOf returns {index}");
            }
            else
            {
                Console.WriteLine($"\nThe name {names[index]} is at index {index}");
            }

            index = names.IndexOf("Not Found");
            if (index == -1)
            {
                Console.WriteLine($"\nWhen an item is not found, IndexOf returns {index}");
            }
            else
            {
                Console.WriteLine($"\nThe name {names[index]} is at inde {index}");
            }


            // item in your list can be sorted as well
            names.Sort();
            Console.WriteLine("\nHere are your names in sorted order");
            foreach (var name in names)
            {
                Console.WriteLine($" {name.ToUpper()}! ");
            }


        } // end WorkingWithStrings()
    }
}
