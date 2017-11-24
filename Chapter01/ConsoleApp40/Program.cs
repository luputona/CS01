using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApp40
{
    class Program
    {
        struct Vector
        {
            public int X;
            public int Y;

            public Vector(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }
            public override string ToString()
            {
                return "X : " + X + "Y, " + Y;
            }
        }
               
        static void Main(string[] args)
        {
            Vector v1 = new Vector();

            Vector v2;
            v2.X = 0;
            v2.Y = 0;

            Vector v3 = new Vector(0, 0);

            //n1,n2,n3는 같은 표현
            int n1 = new int();
            int n2;
            n2 = 0;
            int n3 = 0;

            int n; //n은 0의 값을 갖고 있지만 개발자가 할당한 것은 아니다
            //Console.WriteLine(n); //컴파일 오류 발생
        }
    }
}
