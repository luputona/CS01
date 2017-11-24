﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

abstract class DrawingObject
{
    public abstract void Draw();
    public abstract void Move(int offset);
}

interface IDrawingObject
{
    void Draw();
    void Move(int offset);
}
class Computer
{
}
interface IMoniter //메서드 시그니처만 포함하고 있는 인터페이스
{
    void TurnOn();
}

interface IKeyboard //비어있는 인터페이스 정의 가능
{
}

    
//클래스 상속과 함께 인터페이스로부터 다중 상속 가능
class Notebook : Computer, IMoniter, IKeyboard
{
    public void TurnOn()
    {
    } //추상 메서드와는 달리 override예약어가 필요 없음
}

class Notebook2 : Computer, IMoniter, IKeyboard
{
    void IMoniter.TurnOn() { }
}

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook();
            notebook.TurnOn();

            Notebook2 notebook2 = new Notebook2();
            //notebook2.TurnOn(); // IMoniter.TurnOn 메서드는 Notebook 인스턴스로 호출 불가느으
            //따라서 이 코드는 컴파일 오류가 발생한다.

            IMoniter mon= notebook2 as IMoniter;
            mon.TurnOn(); //반드시 IMoniter인터페이스로 형변환 해서 호출

        }
    }
}
