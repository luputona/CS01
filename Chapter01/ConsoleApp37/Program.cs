﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

class Hardware { }

class USB
{
    string name;
    public USB(string name) { this.name = name; }

    public override string ToString()
    {
        return name;
    }

}
class Notebook : Hardware, IEnumerable // IEnumerable인터페이스 구현
{
    USB[] usbList = new USB[] { new USB("USB1"), new USB("USB2") };

    public IEnumerator GetEnumerator() //GetEnumerator를 구현한 열거자 인스턴스 반환
    {
        return new USBEnumerator(usbList);
    }

    public class USBEnumerator :IEnumerator // 중첩 클래스로 정의된 열거자 타입
    {
        int pos = -1;
        int length = 0;
        object[] list;

        public USBEnumerator(USB[] usb)
        {
            list = usb;
            length = usb.Length;
        }

        public object Current //현재 요소를 반환 하도록 약속된 접근자 메서드
        {
            get
            {
                return list[pos];
            }
        }

        public bool MoveNext() //다음 순서의 요소를 지정하도록 약속된 메서드
        {
            if(pos >= length - 1)
            {
                return false;
            }
            pos++;
            return true;
        }

        public void Reset() //초기화 
        {
            pos = -1;
        }
    }
}

namespace ConsoleApp37
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook();

            foreach(USB usb in notebook)
            {
                Console.Write(usb);
            }
        }
    }
}