/*
Author: Cody Hoang
Date: 1/31/2023
Description: C# Console Application for Deliverable 3
*/

using System;
namespace Deliverable__3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer number between 1 and 100: ");

            try
            {
                int input = int.Parse(Console.ReadLine());

                Console.WriteLine("Specify the series type: Even or Odd ");
                string series = Console.ReadLine();

                if (series == "Odd")
                {
                    Console.WriteLine("You have selected " + series + " series. The numbers between 0 and " + input + " are ");
                    for (int i = 1; i <= input; i = i + 2)
                    {
                        Console.WriteLine(i);

                    }
                }

                if (series == "Even")
                {
                    Console.WriteLine("You have selected " + series + " series. The numbers between 0 and " + input + " are ");
                    for (int i = 0; i <= input; i = i + 2)
                    {
                        Console.WriteLine(i);

                    }
                }


            }
            catch
            {
                Console.WriteLine("Enter an integer number 1 and 100: ");
            }
            

         


        }
    }
}