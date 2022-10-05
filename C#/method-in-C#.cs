using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Program1
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            string num1 = Console.ReadLine ();
            Console.WriteLine("Enter the number: ");
            string num2 = Console.ReadLine();
            Console.WriteLine(sum(num1,num2));
        }
        static double sum(string num1, string num2)
            {
                double num3 = Convert.ToDouble(num1);
                double num4 = Convert.ToDouble(num2);
                return (num3 + num4);
            }
        
    }
}