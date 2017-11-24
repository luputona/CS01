using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApp36
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] { 1, 2, 3, 4, 5 };

            IEnumerator enumerator = intArray.GetEnumerator();

            while(enumerator.MoveNext()) //더이상 열거를 할 수 없을때 false를 반환 
            {
                Console.Write(enumerator.Current + ", ");
            }

            Console.WriteLine();

            foreach(int elem in intArray)
            {
                Console.Write(elem + ", ");
            }

            Console.WriteLine();

            string name = "korea";
            foreach(char ch in name)
            {
                Console.Write(ch + ", ");
            }
        }
    }
}

