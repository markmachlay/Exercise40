using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise40
{
    class Program
    {
        static void Main(string[] args)
        {
            char continueFlag;
            do
            {

                List<int> list = new List<int> { };

                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine("Please enter a number");
                    list.Add(int.Parse((Console.ReadLine())));
                }

                var sortedNumbers = list.OrderBy(n => n);
                int median;
                int halfindex = list.Count() / 2;
                median = sortedNumbers.ElementAt(halfindex);

                Console.WriteLine($"The median of {list[0]}, {list[1]}, {list[2]}, {list[3]} and {list[4]} is {median}");


                Console.WriteLine("Would you like to contine? (y/n)");
                continueFlag = Console.ReadLine().ToLower()[0];
            } while (continueFlag == 'y');
        }    
    }
}
