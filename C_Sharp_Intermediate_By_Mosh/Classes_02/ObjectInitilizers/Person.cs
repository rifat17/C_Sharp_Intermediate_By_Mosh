using System;
namespace C_Sharp_Intermediate_By_Mosh.Classes_02.ObjectInitilizers
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        public static Person Parse(string name)
        {
            var person = new Person();
            person.Name = name;
            return person;
        }
    }
}
