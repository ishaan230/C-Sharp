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
            Console.Write("What's your name?\n");
            string name = Console.ReadLine();
            Console.WriteLine("Hey " + name + " what's up!" );
            Console.WriteLine("What's your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Oh it's nice to know that you are " + age);
        }
        
    }
}