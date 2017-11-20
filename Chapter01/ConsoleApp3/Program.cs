using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Circle
{
    double pi = 3.14;

    public double Pi
    {
        get
        {
            return pi;
        }
        set
        {
            pi = value;
        }
    }
    
}

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle o = new Circle();
            o.Pi = 3.14159; //쓰기
            double piValue = o.Pi; //ㅇ읽기 

        }
    }
}
