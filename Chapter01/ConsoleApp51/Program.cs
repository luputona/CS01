using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Notebook
{
    int inch;
    int memoryGB;

    public Notebook(int inch, int memoryGB)
    {
        this.inch = inch;
        this.memoryGB = memoryGB;
    }

    public int this[string progertyName]
    {
        get
        {
            switch(progertyName)
            {
                case "인치":
                    return inch;
                case "메모리크기":
                    return memoryGB;
            }
            return -1;
        }
    }
}

namespace ConsoleApp51
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook(24,16);

            Console.WriteLine("모니터 인치: " + notebook["인치"] + "\"");
            Console.WriteLine("메모리 크기: " + notebook["메모리크기"] + "GB");

        }
    }
}
