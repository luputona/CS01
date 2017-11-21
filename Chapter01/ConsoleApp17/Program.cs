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
    new public void Move()
    {
        Console.WriteLine("네 발로 움직인다");
    }
}
class Whale : Mammal
{
    new public void Move()
    {
        Console.WriteLine("수영 한다");

    }
}
class Human : Mammal
{
    new public void Move()
    {
        Console.WriteLine("두발로 걷는다");
    }
}


namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            Lion lion = new Lion();
            Mammal one = lion;
            one.Move();

            Human human = new Human();
            Mammal two = human;
            two.Move();
        }
    }
}
