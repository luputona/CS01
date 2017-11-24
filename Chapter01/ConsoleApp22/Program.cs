using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

interface IMoniter
{
    void TurnOn();
    int Inch { get; set; } //프로퍼티 get / set포함
    int Width { get;  } //get만 포함하는 것도 가능
}

class NoteBook : IMoniter
{
    public void TurnOn() { }

    int inch;
    public int Inch
    {
        get { return inch; }
        set { inch = value; }
    }
    int width;
    public int Width
    {
        get
        {
            return width;
        }
    }
}

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            NoteBook notebook = new NoteBook();
            notebook.TurnOn();
        }
    }
}
