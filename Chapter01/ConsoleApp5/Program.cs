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
    bool fingerScan;//Notebook타입에 해당하는 멤버만 추가
    public bool HasFingerScanDevice() { return fingerScan; }   
}
public class Desktop : Computer
{
}
public class Netbook : Computer
{
}
public class DeviceManager
{
    public void TurnOff(Computer device)
    {
        device.Shutdown();
    }

}
namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook();
            Desktop desktop = new Desktop();
            Netbook netbook = new Netbook();
            DeviceManager manager = new DeviceManager();
            manager.TurnOff(notebook);
            manager.TurnOff(desktop);
            manager.TurnOff(netbook);

        }
    }
}
