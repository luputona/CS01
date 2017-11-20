using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "C#";

            switch(text)
            {
                case "C#":
                case "VB.NET":
                    Console.WriteLine(".NET 호환 언어");
                    break;
                case "Java":
                    Console.WriteLine("JVM언어");
                    break;
                default:
                    Console.WriteLine("알 수 없음");
                    break;
            }
            text = "C#";

            if(text == "C#" || text == "VB.NET")
            {
                Console.WriteLine(".NET 호환 언어");
            }
            else if(text == "JAVA")
            {
                Console.WriteLine("JVM 언어");
            }
            else
            {
                Console.WriteLine("알 수 없음");
            }

            //이 switch에는 default가 없다.
            switch(text)
            {
                case "C#":
                    Console.WriteLine(".NET 호환 언어");
                    break;
                case "Java":
                    Console.WriteLine("JVM언어");
                    break;
            }

        }
    }
}
