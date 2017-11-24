using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

[Flags]
enum Days
{
    Sunday = 1, Monday =2 ,Tuesday = 4,
    Wednesday = 8, Thursday = 16, Friday = 32, Saturday = 64
}

namespace ConsoleApp48
{
    class Program
    {
        static void Main(string[] args)
        {
            Days workingDays = Days.Monday | Days.Tuesday | Days.Wednesday | Days.Thursday | Days.Friday;

            Console.WriteLine(workingDays.HasFlag(Days.Sunday)); //sunday를 포함하고있는지 확인

            Days today = Days.Friday;

            Console.WriteLine(workingDays.HasFlag(today)); //today를 포함하고있는가?
            Console.WriteLine(workingDays);

        }
    }
}
