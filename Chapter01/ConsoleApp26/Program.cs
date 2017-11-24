﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

delegate int GetResultDelegate();// int 를 반환하고 매개변수가 없는 델리게이트 타입을 정의
class Target
{
    public void Do(GetResultDelegate getResult)
    {
        Console.WriteLine(getResult()); // 콜ㄹ백 메서드 호출
    }
}
class Source
{
    public int GetResult()//콜백 용도로 전달될 메서드
    {
        return 10;
    }
   
    public void Test()
    {
        Target target = new Target();
        target.Do(new GetResultDelegate(this.GetResult));
    }
}

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            Source source = new Source();
            source.Test();
        }
    }
}
