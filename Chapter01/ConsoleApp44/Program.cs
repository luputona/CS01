using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp44
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1 = 5;
            int value2 = 10;
            SwapValue(ref value1, ref value2);

            Console.WriteLine("value == " + value1 + ", value2 == " + value2);
            
        }
        private static void SwapValue(ref int value1, ref int value2)
        {
            int temp = value1;
            value1 = value2;
            value2 = temp;
        }
    }
}
