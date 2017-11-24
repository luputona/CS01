using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;


namespace ConsoleApp52
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();

            //4개의 요소를 컬렉션에 추가
            ar.Add("Hello");
            ar.Add(6);
            ar.Add("World");
            ar.Add(true);
            
            //숫자 6을 포함하고 있는지 판단
            Console.WriteLine("Contains(6) : " + ar.Contains(6));

            // World 문자열을 컬렉션에서 삭제
            ar.Remove("World");

            ar[2] = false;
            Console.WriteLine();

            foreach(object obj in ar)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
