using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp45
{
    class Program
    {

        struct DividResult
        {
            public bool Success;
            public int Result;

        }

        DividResult Divide(int n1, int n2)
        {
            DividResult ret= new DividResult();
            if(n2 ==0 )
            {
                ret.Success = false;
                return ret;
            }
            ret.Success = true;
            ret.Result = n1 / n2;
            return ret;
        }
        
        static void Main(string[] args)
        {
            Program pg = new Program();
            DividResult result = pg.Divide(50, 0);
            Console.WriteLine(result.Success + ": " + result.Result);

            result = pg.Divide(50,10);

            Console.WriteLine(result.Success + ": " + result.Result);
        }
    }
}
