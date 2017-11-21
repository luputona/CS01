using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Book
{
    decimal isbn13;
    public Book(decimal isbn13)
    {
        this.isbn13 = isbn13;
    }
}

class EBook : Book
{
    public EBook() : base(0)
    {

    }
    public EBook(decimal isbn) :base(0)
    {

    }
}

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
