using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApp53
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();

            ar.Add("Hello");
            ar.Add("World");
            ar.Add("My");
            ar.Add("Sample");
            ar.Sort(); //모든 요소의 타입이 같아야 한다

            foreach(string txt in ar)
            {
                Console.WriteLine(txt);
            }
        }
    }
}
