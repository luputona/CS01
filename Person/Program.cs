using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class CPerson
{
    static public int CountOfInstance;

    public string _name;

    public CPerson(string name)
    {
        CountOfInstance++;
        _name = name;
    }
}


namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            //인스턴스ㅏ인 경우
            
            Console.WriteLine(CPerson.CountOfInstance); //출력 결과 : 0
            CPerson person1 = new CPerson("홍길동");
            CPerson person2 = new CPerson("홍길순");
            Console.WriteLine(CPerson.CountOfInstance);//출력결과 : 2

        }
    }
}
