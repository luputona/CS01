using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace ConsoleApp55
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            //4개의 요소를 컬렉션에 추가
            ht.Add("Key1", "add");
            ht.Add("Key2","remove");
            ht.Add("Key3", "update");
            ht.Add("Key4", "search");
            

            //key4 키 값에 해당ㅇ하는 값을 출력
            Console.WriteLine(ht["Key4"]);

            //key3 키 값에 해당하는 요소를 컬렉션에서 삭제
            ht.Remove("Key3");

            //key2 키 값에 해당하는 값을 delete로 변경
            ht["Key2"] = "delete";
            Console.WriteLine();

            //컬렉션의 모든 키 값을 열람 하고 그 킹에 대응되는 값을 출력
            foreach(object key in ht.Keys)
            {
                Console.WriteLine("{0} ==> {1}", key, ht[key]);
            }
            

        }
    }
}
