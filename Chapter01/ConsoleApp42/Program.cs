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

namespace ConsoleApp42
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector v1;

            v1.X = 5;
            v1.Y = 10;

            Change(v1); //메서드 호출 후 v1의 값에는 변함이 없음.
            Console.WriteLine("v1: X = " + v1.X + ", Y = " + v1.Y);

            Point pt1 = new Point();

            pt1.X = 5;
            pt1.Y = 10;

            Change(pt1); //메서드 호출 후 pt1의 값이 변함
            Console.WriteLine("pt1 : X = " + pt1.X + ", Y = " + pt1.Y);
        }

        private static void Change(Vector vt)
        {
            vt.X = 7;
            vt.Y = 14;
        }
        private static void Change(Point pt)
        {
            pt.X = 7;
            pt.Y = 14;
        }
    }
}
