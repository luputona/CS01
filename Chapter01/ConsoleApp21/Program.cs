﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Kilogram
{
    double mass;

    public Kilogram(double value)
    {
        this.mass = value;
    }

    public Kilogram Add(Kilogram target)
    {
        return new Kilogram(this.mass + target.mass);
    }

    public override string ToString()
    {
        return mass + "kg";
    }
    public static Kilogram operator +(Kilogram op1, Kilogram op2)
    {
        return new Kilogram(op1.mass + op2.mass);
    }
}

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 5;
            int n2 = 10;
            int sum = n1 + n2; //sum 값은 15

            string txt1 = "123";
            string txt2 = "456";
            Console.WriteLine(txt1 + txt2);//출력 결과 123456

            Kilogram kg1 = new Kilogram(5);
            Kilogram kg2 = new Kilogram(10);

            Kilogram kg3 = kg1.Add(kg2);
            Console.WriteLine(kg3);//출력 결과 : 15kg

            kg3 = kg1 + kg2;
            Console.WriteLine(kg3);
        }
    }
}