using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Mammal
{
    public void Move()
    {
        Console.WriteLine("이동한다");
    }
}

class Lion : Mammal
{
    public void Move()
    {
        Console.WriteLine("네 발로 움직인다");
    }
}

class Whale : Mammal
{
    public void Move()
    {
        Console.WriteLine("수영한다.");
    }
}
class Human : Mammal
{
    public void Move()
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
            Mammal one = new Mammal();
            one.Move();

            Lion lion = new Lion();
            lion.Move();

            Whale whale = new Whale();
            whale.Move();

            Human human = new Human();
            human.Move();

            Lion lion2 = new Lion();
            Mammal one2 = lion2; //부모타입으로 형변환
            one2.Move();

        }
    }
}
