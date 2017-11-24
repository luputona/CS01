using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
interface IDrawingObject
{
    void Draw();
}

class Line: IDrawingObject
{
    public void Draw()
    {
        Console.WriteLine("Line");
    }
}
class Rectangle : IDrawingObject
{
    public void Draw()
    {
        Console.WriteLine("Rectangle");
    }
}

namespace ConsoleApp32
{
    class Program
    {
        static void Main(string[] args)
        {
            //ㅇ인터페이스 자체는 new 로 인스턴스화 할 수 없지만 인터페이스 배열은 가능하다.
            IDrawingObject[] instances = new IDrawingObject[] { new Line(), new Rectangle() };

            foreach(IDrawingObject item in instances)
            {
                item.Draw(); //인터페이스를 상속받은 개체의 Draw메서드가 호출됨.
            }

            //자식 클래스로부터 암시적 형변환 가능
            IDrawingObject instance = new Line();
            instance.Draw();
        }
    }
}
