﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp28
{
    class Program
    {
        public delegate bool CompareDelegate(int arg1, int arg2);

        class SortObject // 배열을 정렬할 수 있는 기능을 가진 타입 정의
        {
            int[] numbers;

            public SortObject(int[] numbers)
            {
                this.numbers = numbers;
            }

            public void Sort(CompareDelegate compareMethod) //전형적인 선택 정렬 알고리즘
            {
                int temp;

                for(int i =0; i < numbers.Length; i++)
                {
                    int lowPos = i;

                    for(int j = i + 1; j < numbers.Length; j++)
                    {
                        if(compareMethod(numbers[j], numbers[lowPos]))
                        {
                            lowPos = j;
                        }
                    }
                    temp = numbers[lowPos];
                    numbers[lowPos] = numbers[i];
                    numbers[i] = temp;
                }
            }
            public void Display() // numbers 요소를 화면에 출력
            {
                for (int i = 0; i < numbers.Length;i++)
                {
                    Console.Write(numbers[i] + ", ");
                }
            }
        }

        static void Main(string[] args)
        {
            int[] intArray = new int[] { 5, 2, 3, 1, 0, 4 };

            SortObject so = new SortObject(intArray);

            so.Sort(AscendingCompare);
            so.Display();

            Console.WriteLine();

            so.Sort(DescendingCompare);
            so.Display();
        }

        public static bool AscendingCompare(int arg1, int arg2)
        {
            return (arg1 < arg2);
        }

        public static bool DescendingCompare(int arg1, int arg2)
        {
            return (arg1 > arg2);
        }
    }
}
