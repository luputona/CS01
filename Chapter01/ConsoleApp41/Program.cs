﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

struct Vector
{
    public int X;
    public int Y;
}
class Point
{
    public int X;
    public int Y;
}

namespace ConsoleApp41
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector v1;

            v1.X = 5;
            v1.Y = 10;

            Vector v2 = v1; // 값 형식의 대입은 인스턴스의 메모리 자체가 복사됨.
            v2.X = 7;
            v2.Y = 14;

            Console.WriteLine("v1: X = " + v1.X + ", Y = " + v1.Y);
            Console.WriteLine("v2: X = " + v2.X + ", Y = " + v2.Y);

            Point pt1 = new Point();

            pt1.X = 5;
            pt1.Y = 10;

            Point pt2 = pt1; //참조 형식의 대입은 참조 주소만 복사됨.
            pt2.X = 7;
            pt2.Y = 14;

            Console.WriteLine("pt1 : = " + pt1.X + ", Y = " + pt1.Y);
            Console.WriteLine("pt2 : = " + pt2.X + ", Y = " + pt2.Y);

        }
    }
}
