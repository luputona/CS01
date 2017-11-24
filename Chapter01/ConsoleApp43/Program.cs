using System;
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

namespace ConsoleApp43
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector v1;

            v1.X = 5;
            v1.Y = 10;

            Change(ref v1);//메서드 호출 시 ref 예약어 사용
            Console.WriteLine("v1: X = " + v1.X + ", Y = " + v1.Y);

            Point pt1 = new Point();

            pt1.X = 5;
            pt1.Y = 10;

            Change(ref pt1); //메서드 호출 ref예약어 사용
            Console.WriteLine("pt1 : X = " + pt1.X + ", Y = " + pt1.Y);

        }

        static void Change(ref Vector vt) // 메서드  측에도 해당 매개변수에 ref 예약어를 사용
        {
            vt.X = 7;
            vt.Y = 14;

        }

        static void Change(ref Point pt) // 첫번째 매개변수에 ref 예약어 사용
        {
            pt.X = 7;
            pt.Y = 14;
        }
    }
}
