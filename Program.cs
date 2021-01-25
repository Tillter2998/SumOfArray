using System;
using System.Collections.Generic;

namespace SumOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int[] numArray;
            int arraySum = 0;

            try
            {
                Console.WriteLine("Enter numeric array values seperated by commas. Ex 5,3,6,5");
                var values = Console.ReadLine();

                // Split the string into an array
                string[] stringArray = values.Split(',');

                // Convert the string array into a List of integers
                foreach (string num in stringArray)
                {
                    if (string.IsNullOrEmpty(num))
                    {
                        numbers.Add(0);
                    }
                    else
                    {
                        if (!Int32.TryParse(num, out int number))
                        {
                            throw new Exception("Input values must be numbers");
                        }
                        numbers.Add(number);
                    }

                }

                // Convert the list to an array in order to show that I can find the sum of an array
                numArray = numbers.ToArray();

                foreach (int num in numArray)
                {
                    arraySum = arraySum + num;
                }

                Console.WriteLine($"The sum of the array is {arraySum}");


            }
            catch (Exception e)
            {
                Console.WriteLine($"Something went Wrong: {e}");
            }

            Console.ReadLine();
        }
    }
}
