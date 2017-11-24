using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp46
{
    class Program
    {
        bool Divide(int n1, int n2, out int result)
        {
            if(n2 == 0)
            {
                result = 0;
                return false;
            }
            result = n1 / n2;
            return true;
        }

        static void Main(string[] args)
        {
            Program pg = new Program();

            int quotient;
            if(pg.Divide(15, 3, out quotient) == true)
            {
                Console.WriteLine(quotient);
            }

        }
    }
}
