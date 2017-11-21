using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Mathematics
{
    //public int AbsInt(int value)
    //{
    //    return (value >= 0) ? value : ~value;
    //}

    //public double AbsDouble(double value)
    //{
    //    return (value >= 0) ? value : -value;
    //}
    //public decimal Absdecimal(decimal value)
    //{
    //    return (value >= 0) ? value : -value;
    //}
    
    public int Abs( int value)
    {
        return(value >= 0) ? value : -value;
    }

    public double Abs(double value)
    {
        return (value >= 0) ? value : -value;
    }
    public decimal Abs(decimal value)
    {
        return (value >= 0) ? value : -value;
    }

}

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            Mathematics math = new Mathematics();

            Console.WriteLine(math.Abs(-5));
            Console.WriteLine(math.Abs(-10.052));
            Console.WriteLine(math.Abs(20.01m));

        }
    }
}
