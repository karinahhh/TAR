using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARpv
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your name, please : ");
            string name = Console.ReadLine();

            //Console.WriteLine("Hi, "+name+", nice to meet you");

            Console.WriteLine($"Hi,{name}, nice to meet you") ;

            Console.ReadLine();
        }
    }
}
