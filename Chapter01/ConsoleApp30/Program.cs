﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Person
{
    public int Age;
    public string Name;

    public Person(int age, string name)
    {
        this.Age = age;
        this.Name = name;
    }

    public override string ToString()
    {
        return Name + ": " + Age;
    }

}
delegate bool CompareDelegate(Person arg1, Person arg2);

class SortPerson
{
    Person[] men;

    public SortPerson(Person[] men)
    {
        this.men = men;
    }

    public void Sort(CompareDelegate compareMethod)
    {
        Person temp;

        for(int i = 0;i< men.Length; i++)
        {
            int lowPos = i;

            for(int j = i + 1; j < men.Length; j++)
            {
                if(compareMethod(men[j], men[lowPos])
                {
                    lowPos = j;
                }
            }

            temp = men[lowPos];
            men[lowPos] = men[i];
            men[i] = temp;
        }
    }
    public void Display()
    {
        for(int i =0; i < men.Length; i++)
        {
            Console.WriteLine(men[i] + ", ");
        }
    }
}

namespace ConsoleApp30
{
    class Program
    {
        static bool AscSortByName(Person arg1, Person arg2)
        {
            //string 객체의 CompareTo메서드는 문자열 비교를 수행
            //문자열이 사전 정렬 순으로 비교해서 크면1,  같으면 0  작으면 -1 을 반환
            //따라서 0보다 작은 값을 반환한 경우를 true로 가정하면 오름차순 정렬
            return arg1.Name.CompareTo(arg1.Name) < 0;
        }

        static void Main(string[] args)
        {
            Person[] personArray = new Person[]
            {
                new Person(51, "Anders"),
                new Person(37, "Scott"),
                new Person(45, "Peter"),
                new Person(62, "Mads")
            };

            SortPerson so = new SortPerson(personArray);
            so.Sort(AscSortByName);
            so.Display();
        }
    }
}
