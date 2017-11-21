using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Computer
{
    virtual public void Boot()
    {
        Console.WriteLine("메인보드 켜기");
    }
}

public class Notebook : Computer
{

    public override void Boot()
    {
        base.Boot();
        Console.WriteLine("화면 켜기");
    }

}

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
