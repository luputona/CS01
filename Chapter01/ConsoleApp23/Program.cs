using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Disk
{
    public int Clean(object arg)
    {
        Console.WriteLine("작업 실행");
        return 0;
    }
}


namespace ConsoleApp23
{
    class Program
    {
        delegate int FuncDelegate(object arg);

        static void Main(string[] args)
        {
            Disk disk = new Disk();

            FuncDelegate cleanFunc = new FuncDelegate(disk.Clean);
            FuncDelegate workFunc = disk.Clean;

            disk.Clean(null); //clean 메서드를 직접 호출
            cleanFunc(null); // 델리게이트 인ㄴ스턴스를 통해 Clean 메서드를 호출

        }
    }
}
