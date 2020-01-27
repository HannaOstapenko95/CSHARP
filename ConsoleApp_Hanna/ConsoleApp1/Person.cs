using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PERSON_NAM
{
    public class User1
    {
        public int age;
        public string name;
    }
    class Person
        {
            public int age;
            string name;
            public void Display()
            {
                Console.WriteLine($"Name: {name}");
            }
            public int age1;
            //Конструктор вызывает конструктор
            public Person() : this("Неизвестно")
            {
            }
            public Person(string name) : this(name, 18)
            {
            }
            public Person(string name, int age1)
            {
                this.name = name;
                this.age = age;
            }
        
    }

    public class Person1 //shadowing / hiding
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        protected string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Person1(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public readonly int x = 10;
        public const int G = 5;

        public void Display()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }

    public class Employee : Person1
    {
        public string Company { get; set; }
        public new readonly int x = 20;
        public new const int G = 15;
        public new string Name
        {
            get { return "Employee " + base.Name; }
            set { name = value; }
        }
        public Employee(string firstName, string lastName, string company)
                : base(firstName, lastName)
        {
            Company = company;
        }
        public new void Display()
        {
            Console.WriteLine($"{FirstName} {LastName} works in {Company}");
        }
    }

    public class PersonException : Exception
    {
        public PersonException(string message)
            : base(message)
        { }
    }
}
