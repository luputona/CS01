using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Point
{
    int x, y;

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public override string ToString()
    {
        return "X: " + x + ", Y: " + y;
    }
}
abstract class DrawingObject //추상 클래스
{
    public abstract void Draw(); //추상 메서드 코드없는 가상 메서드)
    public void Move()
    {
        Console.WriteLine("Move"); //일반 메서드도 정의 가능
    }
}
class Line : DrawingObject
{
    Point pt1, pt2;

    public Line(Point pt1, Point pt2)
    {
        this.pt1 = pt1;
        this.pt2 = pt2;
    }

    public override void Draw()
    {
        Console.WriteLine("Line " + pt1.ToString() + " ~ " + pt2.ToString());
    }
}

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawingObject line = new Line(new Point(10, 10), new Point(20, 20));
            line.Draw(); //다형성에 따라 Line.Draw()가 호출됨
        }
    }
}
