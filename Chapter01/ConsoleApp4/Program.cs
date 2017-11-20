using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Computer
{
    protected bool powerOn;
    public void Boot() { }
    public void Shutdown() { }
    public void Reset() { }
}
public class Notebook : Computer
{
    bool fingerScan;

    public bool HasFingerScanDevice() { return fingerScan; }

    public void CloseLid()
    {
        if(powerOn == true)
        {
            Shutdown(); //Notebook에서 추가된 메서드 내에서 부모의 메서드 호출
        }
    }
}
namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook();
            Computer pc1 = notebook; //암시적 형변환 가능
            pc1.Boot();
            pc1.Shutdown();

            Computer pc = new Computer();
            //Notebook notebook = (Notebook)pc; //명시적 형변환, 컴파일은 가능 실행하면 오류 발생

            notebook = new Notebook();
            pc1 = notebook; //부모 타입으로 암시적 형변환
            Notebook note2 = (Notebook)pc1; //다시 본래 타입으로 명시적 형변환
            note2.CloseLid();

        }
    }
}
