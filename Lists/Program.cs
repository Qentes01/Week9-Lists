using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myWishes = new List<string>();
            myWishes.Add("Right soscks");
            myWishes.Add("Left soscks");
            myWishes.Add("Porsche Panamera or Taycan Turbo S");
            myWishes.Add("Harry Potter wand");

            //Console.WriteLine($"There are {myWishes.Count} items on your wish list.");

            //Console.WriteLine(myWishes[0]);
            //Console.WriteLine(myWishes[myWishes.Count-1]);

            foreach(string wish in myWishes)
            {
                Console.WriteLine($"item on your wish list: {wish}");
            }

            Console.WriteLine("Enter a wish:");
            string userWish = Console.ReadLine();

            myWishes.Add(userWish);

            foreach(string wish in myWishes)
            {
                Console.WriteLine($"Item on your wish list: {wish}");
            }

        }
    }
}
