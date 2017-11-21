using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Computer
{
    bool powerOn;
    public void Boot() { }
    public void Shutdouw() { }
    public void Reset() { }
}

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer();
            Type type = computer.GetType();
            Console.WriteLine(type.FullName); // Type 클래스의 Fullname 프로퍼티 호출
            Console.WriteLine(type.IsClass);    //Type 클래스의 IsClass 프로퍼티 호출
            Console.WriteLine(type.IsArray);    //

            int n = 5;
            string txt = "text";
            Type intTpye = n.GetType();
            Console.WriteLine(intTpye.FullName);
            Console.WriteLine(txt.GetType().FullName);

            type = typeof(double);
            Console.WriteLine(type.FullName);
            Console.WriteLine(typeof(System.Int16).FullName);



        }
    }
}
