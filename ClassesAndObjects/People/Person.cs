using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAndObjects.People //'.People' links the program into another namespace (another folder where the 'person' script is in)
{
    public class Person
    {
        public string Name;
        public int age;
        public bool HasPet;

        public void Greeting()
        {
            Console.WriteLine("Hey! My name is " + Name + " and I am " + age + " years old.");
        }
    }

}
