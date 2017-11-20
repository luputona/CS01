using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };

            foreach(int elem in arr)
            {
                Console.WriteLine(elem);
            }

            arr = new int[] { 1, 2, 3, 4, 5 };

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }
}
