using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Computer
{
    public void TurnOn()
    {
        Console.WriteLine("computer: TurnOn");
    }
}

class Moniter
{
    public void TurnOn()
    {
        Console.WriteLine("Moniter: TurnOn");
    }
}

class Switch
{
    public void PowerOn(Computer machine) // Computer타입을 직접 사용 한다
    {
        machine.TurnOn();
    }
}

namespace ConsoleApp38
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer();
            Switch sw = new Switch();

            sw.PowerOn(computer);

            Moniter moniter = new Moniter();
            //sw.PowerOn(moniter);

        }

    }
}
