using System;
using System.IO;

namespace FileCreate
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootdirectory = @"C:\Users\opilane\Samples\wishlist";
            string filename = "wishlist";
            string fullfilePath = $@"{rootdirectory}\{filename}.txt";
            Console.WriteLine(fullfilePath);

            bool fileExists = File.Exists(fullfilePath);
            bool directoryExists = File.Exists(fullfilePath);
            if (directoryExists && fileExists)
            {
                Console.WriteLine($"File {filename} already exists in {rootdirectory}");
            }
            else if (!directoryExists)
            {
                Console.WriteLine("wishlist directory doesn't exist.");
                Directory.CreateDirectory(rootdirectory);
                File.Create(fullfilePath);
                Console.WriteLine($"File {filename}.txt has been created");
            }
            else
            {
                File.Create(fullfilePath);
                Console.WriteLine($"File {filename}.txt has been created");
            }

        }
    }
}
