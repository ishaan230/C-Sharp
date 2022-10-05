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
            bool isMale = false;
            bool isAdult = false;
            if(isMale)
            {
                Console.WriteLine("You are male");
            }
            else if(isAdult)
            {
                Console.WriteLine("you are adult");
            }
            else
            {
                Console.WriteLine("LOL");
            }
        }
        
    }
}