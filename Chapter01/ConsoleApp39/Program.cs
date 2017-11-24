using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*인터페이스 느슨한 결합d*/

interface IPower
{
    void TurnOn();
}

class Computer : IPower
{
    public void TurnOn()
    {
        Console.WriteLine("Computer: TurnOn");
    }
}

class Moniter : IPower
{
    public void TurnOn()
    {
        Console.WriteLine("Monitor: TurnOn");
    }
}
class Switch
{
    public void PowerOn(IPower machine) //특정 타입 ->인터페이스
    {
        machine.TurnOn();
    }
}

namespace ConsoleApp39
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer();
            Switch sw = new Switch();

            sw.PowerOn(computer);

            Moniter moniter = new Moniter();
            sw.PowerOn(moniter);
        }
    }
}
