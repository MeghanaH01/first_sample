using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
internal class MinMax
  {
        int[] intArray;
        int size;
        public void GetDetails()
        {
            Console.WriteLine("Enter the size of the array:");
            size = Convert.ToInt32(Console.ReadLine());
            intArray = new int[size];
            // Accept values into the array

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter {i + 1} integer values:");

                intArray[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void DisplayDetails() {
            Array.Sort(intArray);
            int min = intArray[0];
            int max = intArray[intArray.Length-1];
            Console.WriteLine($"Minimum value: {min}");
            Console.WriteLine($"Maximum value: {max}");
        }
    }
}

