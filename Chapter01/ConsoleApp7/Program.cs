﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine(program.ToString());

            int n = 500;
            double d = 3.1415926535897932384626;
            string txt = "Hello: ";

            Console.WriteLine(txt + n.ToString());
            Console.WriteLine(txt + d.ToString());

            txt = d.ToString();
            Console.WriteLine(txt);

        }
    }
}
