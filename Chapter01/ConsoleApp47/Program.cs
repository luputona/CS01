using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

enum Days
{
    Sunday, Monday, Tuesday, WednesDay, Thursday, Friday, Saturday
}

namespace ConsoleApp47
{
    class Program
    {
        static void Main(string[] args)
        {
            Days today = Days.Sunday;
            Console.WriteLine(today); //출력결과 : sunday


            today = Days.Sunday;
            int n = (int)today; //enum에서 int 형으로 명시적 변환
            short s = (short)today; //enum에서 short 형으로 명시적 변환

            today = (Days)5; //숫자형에서 enum 형으로 명시적 변환

            Console.WriteLine(today);//출력결과 : Friday

            
        }
    }
}
