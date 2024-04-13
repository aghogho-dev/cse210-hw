using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow;

namespace Prep4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a list of numbers, type 0 when finished.\n");

            List<int> numList = new List<int>();

            while (true) 
            {
                Console.Write("Enter number: ");
                string num = Console.ReadLine();
                int numInt = int.Parse(num);

                if (numInt == 0) break;

                numList.Add(numInt);

            }

            Console.WriteLine($"\nThe sum is: {numList.Sum()}");
            Console.WriteLine($"The average is: {numList.Average()}");
            Console.WriteLine($"The largest number is: {numList.Max()}");
            Console.WriteLine($"The smallest positive number is: {numList.Where(n => n > 0).Min()}");

            numList.Sort();

            Console.WriteLine("\nThe sorted list is:");

            foreach (int number in numList) Console.WriteLine(number);
        
        }
    }
}
