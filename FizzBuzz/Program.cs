using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i < 144; i++)
            {
                List<String> response = FizzBuzz35711(i);

                if (response.Count == 0)
                {
                    Console.WriteLine(i);
                }
                var joinedResponse = String.Join("",response.ToArray());
                Console.WriteLine(joinedResponse);
            }
            
        }

        
        private static List<string> FizzBuzz35711(int i)
        {
            string multipleOfThree = "Fizz";
            string multipleOfFive = "Buzz";
            string multipleOfSeven = "Bang";
            string multipleOfEleven = "Bong";
            string multipleOfThirteen = "Fezz";
            List<string> response = new List<string>();
            if (i % 11 == 0)
            {
                response.Add(multipleOfEleven);
                if (i % 13 == 0)
                {
                    response.Add(multipleOfThirteen);
                }
                return response;
            }
            
                if (i % 3 == 0)
                {
                    response.Add(multipleOfThree);
                }
                if (i % 5 == 0)
                {
                    response.Add(multipleOfFive);
                }
                if (i % 7 == 0)
                {
                    response.Add(multipleOfSeven);
                }

                return response;
        }
    }

}
