using System;
using System.Linq;

namespace Question1
{
    class Program
    {
        static void TotalArray(int[] input)
        {
            int output = 0;
            foreach (var item in input)
            {
                if (item % 2 == 0)
                {
                    output += 1;
                    if (item == 8)
                    {
                        output += 5;
                    }
                }
                else output += 3;
                
            }
            Console.WriteLine(output);
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter numbers seperated by comma (e.g 1,2,3):");
            string inputParams = Console.ReadLine();
            var splitInput = inputParams.Split(',');
            var input = splitInput.Select(int.Parse).ToArray();
            TotalArray(input);
            Console.ReadKey();
        }        
    }
}
