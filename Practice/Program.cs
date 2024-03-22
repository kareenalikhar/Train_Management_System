using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "Hello";
            for(int i=input.Length ;i<0; i--) 
            {
                Console.WriteLine(input[i]);
            }
            Console.ReadKey();
        }
    }
}
