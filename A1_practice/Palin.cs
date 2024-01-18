using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1_practice
{
    internal class Palin
    {
        int n;
        string[] sentance;
        int c = 0;
        public void Get()
        {
            Console.WriteLine("enter n:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the sentances:");
            
            if (n<=100 && n>=1)
            {
                sentance = new string[n];
                for (int i=0;i<n;i++)
                {
                    sentance[i] = Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }

        public void Display()
        {
            //foreach(var c in sentance)
            //{
            //    Console.WriteLine(c);
            //}
            foreach (var sent in sentance)
            {
                string[] strings = sent.Split(' ');
                /********** function call to reverse the sentance ************/

                foreach (var str in strings)
                {

                    for (int i = 0, j = str.Length - 1; i < str.Length / 2; i++, j--)
                    {
                        if (str[i] == str[j])
                        {
                            c++;
                        }
                    }

                    if (c != str.Length / 2)
                    {
                        c = 0;
                        char[] ch = str.ToCharArray();
                        Array.Reverse(ch);
                        Console.Write(ch);

                        Console.Write(" ");

                    }
                    else
                    {
                        c = 0;
                    }

                }

                Console.WriteLine();

            }
        }
    }
}
