using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3Day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int percentage;
            Console.WriteLine("Enter your percentage here");
            percentage =int.Parse(Console.ReadLine());
            if (percentage>=90)
            {
                Console.WriteLine("A");
            }
            else if(percentage>=80 && percentage <= 89)
            {
                Console.WriteLine("B");
            }
            else if (percentage >= 70 && percentage <= 79)
            {
                Console.WriteLine("C");
            }
            else if (percentage >=60 && percentage <=68)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("f");
            }
            

            }

        }
    }

