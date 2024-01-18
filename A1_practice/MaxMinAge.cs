using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace A1_practice
{
    internal class MaxMinAge
    {
        int n;
        int[] array;


        public void Get()
        {
            Console.WriteLine("Enter n:");
            n = Convert.ToInt32(Console.ReadLine());
            array = new int[n];
            Console.WriteLine("Enter ages:");
            for(int i=0;i<array.Length; i++)
            {
                array[i]=Convert.ToInt32(Console.ReadLine());
            }

        }

        public void Display()
        {
            Console.WriteLine("Min={0}", array.Min());
            Console.WriteLine("Max={0}",array.Max());
            
        }

    }
}
