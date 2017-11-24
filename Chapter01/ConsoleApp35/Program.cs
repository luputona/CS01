using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

class IntegerCompare : IComparer // ICompater를 상속받는 타입 정의 
{
    //IComparer 인터페이스의  Comparer메서드를 구현
    //이 메서드는 Array.Sort메서드 내에서 콜백으로 호출됨
    public int Compare(object x, object y)
    {
        int xValue = (int)x;
        int yValue = (int)y;

        if(xValue > yValue) //내림차순 정렬이 되도록 -1을 반환
        {
            return -1;
        }
        else if(xValue == yValue)
        {
            return 0;
        }
        return 1;
    }
}

namespace ConsoleApp35
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] { 1, 2, 3, 4, 5 };

            Array.Sort(intArray, new IntegerCompare());

            foreach(int item in intArray)
            {
                Console.WriteLine(item + ", ");
            }
        }
    }
}
