using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;




namespace ConsoleApp10
{
    class Program
    {
        private static void OutputArrayInfo(Array arr)
        {
            Console.WriteLine("배열의 차원 수 : " + arr.Rank);
            Console.WriteLine("배열의 요소 수 : " + arr.Length);
            Console.WriteLine();
        }
        private static void OutputArrayElements(string title ,Array arr)
        {
            Console.WriteLine("[" + title + "]");


            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr.GetValue(i) + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            bool[,] boolArray = new bool[,] { { true, false }, { false, false } };
            OutputArrayInfo(boolArray);

            int[] intArray = new int[] { 5, 4, 3, 2, 1, 0 };
            OutputArrayInfo(intArray);
            OutputArrayElements("원폰 int array", intArray);

            Array.Sort(intArray);

            OutputArrayElements("Array.Sort 후 intArray ", intArray);

            int[] copyArray = new int[intArray.Length];
            Array.Copy(intArray, copyArray, intArray.Length); //copy정적 메서드

            OutputArrayElements("intArray로 부터 복사된 copyArray", copyArray);


        }
    }
}
