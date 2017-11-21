using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*=================== 4.3.4 this===============*/

class Book
{
    decimal isbn;

    public decimal ISBN
    {
        get { return this.isbn; }
    }
    public Book(decimal isbn)
    {
        this.isbn = isbn;
    }
    public decimal GetISBN()
    {
        return this.ISBN;
    }
    public void Sell()
    {
        Console.WriteLine("sell : " + this.GetISBN());
    }
}


namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
