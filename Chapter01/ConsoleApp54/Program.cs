﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;


public class Person : IComparable
{
    public int Age;
    public string Name;

    public Person(int age, string name)
    {
        this.Age = age;
        this.Name = name;
    }

    public int CompareTo(object obj) // 나이순으로 정렬한다
    {
        Person target = (Person)obj;
        if(this.Age > target.Age)
        {
            return 1;
        }
        else if(this.Age == target.Age)
        {
            return 0;
        }
        return -1;
    }

    public override string ToString()
    {
        return string.Format("{0} ({1})", this.Name, this.Age);
    }

}

namespace ConsoleApp54
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar= new ArrayList();

            ar.Add(new Person(32, "Cooper"));
            ar.Add(new Person(56, "Anderson"));
            ar.Add(new Person(17, "Sammy"));
            ar.Add(new Person(27,"Paul"));

            ar.Sort();

            foreach(Person person in ar)
            {
                Console.WriteLine(person);
            }

        }
    }
}
