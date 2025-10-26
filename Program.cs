using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingWritingArray
{
    public class Program
    {
        static void Main()
        {
            // Create an array
            int[] squareNumbers = new int[10];


            // Loop via each of the array indexes, from 0 to 9.
            for (int i = 0; i < squareNumbers.Length; i++)
            {
                int square = (i + 1) * (i + 1);

                squareNumbers[i] = square;
               
            }
           
            // Writes out each element squared from the above for loop.
            foreach (int elements in squareNumbers)
            {
                Console.WriteLine($"Here are all the array's values squared = {elements}");
            }

            Console.WriteLine("This is the value of index 3 = {0}. ",  squareNumbers[3]);
            Console.WriteLine("The array has {0} dimensions. ", squareNumbers.Rank);
            Console.WriteLine("And this array capacity can hold up to {0} elements. ", squareNumbers.Length);
            Console.ReadKey();            

        }
    }
}
