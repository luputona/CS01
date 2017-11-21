﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*=========================== 4.15 this 를 이용한 생성자 코드 재사용*/

class Book
{
    string title;
    decimal isbn13;
    string author;

    public Book(string title) :this(title, 0)
    {

    }
    public Book(string title, decimal isbn13) : this(title,isbn13, string.Empty)
    {

    }

    //초기화 코드를 하나의 생성자에서 처리
    public Book(string title, decimal isbn13, string author)
    {
        this.title = title;
        this.isbn13 = isbn13;
        this.author = author;
    }
    public Book () : this(string.Empty, 0, string.Empty)
    {

    }
}


namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Book gulliver = new Book();
        }
    }
}
