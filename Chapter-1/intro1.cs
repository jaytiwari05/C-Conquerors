using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Your Surname");
            string surname = Console.ReadLine();
            Console.WriteLine("Enter Your Age");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Hello " + name +" "+ surname+ ",\n" + "Good Morning\nAge is "+ age+"\n \n" );
            Console.WriteLine("Hello {0} {1},\nGood Morning\nAge is {2} ", name ,surname, age );
            

        }
    }
}