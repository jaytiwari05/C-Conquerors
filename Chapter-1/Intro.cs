using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter-1
{
    class Intro
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name");
            string name = Console.ReadLine();
            string age = Console.ReadLine();

            Console.WriteLine("Hello " + name + ",\n" + "Good Morning\nAge is "+ age+"\n \n" );
            Console.WriteLine("Hello {0},\nGood Morning\nAge is {1} ", name , age );

        }
    }
}