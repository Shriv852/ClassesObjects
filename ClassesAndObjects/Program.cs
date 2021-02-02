using System;
using ClassesAndObjects.People;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(); //Instantiating a class so that the program would run
            person.Name = "Lewis";
            person.age = 29;
            person.HasPet = true;

            person.Greeting();
        }
    }
}
