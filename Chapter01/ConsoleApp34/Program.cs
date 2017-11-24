using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

interface ISource
{
    int GetResult(); //코랩ㄱ용으로 사용될 메서드를 인터페이스로 분리한다.
}

class Source : ISource
{
    public int GetResult()
    {
        return 10;
    }
    public void Test()
    {
        Target target = new Target();
        target.Do(this);
    }
}

class Target
{
    public void Do(ISource obj) //Source 타입이 아닌 ISource 인터페이스를 받는다
    {
        Console.WriteLine(obj.GetResult()); //콜백 메서드 호출
    }
}

namespace ConsoleApp34
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
