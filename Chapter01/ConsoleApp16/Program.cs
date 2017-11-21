using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Mammal
{
    virtual public void Move()
    {
        Console.WriteLine("이동한다");
    }
}

class Lion : Mammal
{
    override public void Move()
    {
        Console.WriteLine("네 발로 움직인다");
    }
}

class Whale : Mammal
{
    override public void Move()
    {
        Console.WriteLine("수영한다.");
    }
}
class Human : Mammal
{
    override public void Move()
    {
        Console.WriteLine("두 발로 움직인다.");
    }
}

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Lion lion = new Lion();
            Mammal one = lion; //부모타입으로 형변환
            one.Move();

            Human human = new Human();
            Mammal two = human;
            two.Move();

        }
    }
}
