using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
    public class PersonManager
    {
        public Person CreatePerson(string first, string last, bool isSupervisor)
        {
            Person ret = null;
            if (!string.IsNullOrEmpty(first))
            {
                if (isSupervisor)
                {
                    ret = new Supervisor();
                }
                else
                {
                    ret = new Employee();
                }
                //Assign variables
                ret.FirstName = first;
                ret.LastName = last;
            }
            return ret;
        }

        public List<Person> GetPeople()
        {
            List<Person> people = new List<Person>();
            people.Add(new Person() { FirstName = "Paul", LastName = "Sheriff" });
            people.Add(new Person() { FirstName = "John", LastName = "Kuhn" });
            people.Add(new Person() { FirstName = "Jim", LastName = "Ruhl" });
            return people;
        }

        public List<Person> GetSupervisors()
        {
            List<Person> people = new List<Person>();
            people.Add(CreatePerson("Paul", "Sheriff", true));
            people.Add(CreatePerson("Michael", "Krasowski", true));

            return people;
        }

        public List<Person> GetEmployees()
        {
            List<Person> people = new List<Person>();
            people.Add(CreatePerson("Steve", "Nystrom", false));
            people.Add(CreatePerson("John", "Kuhn", false));
            people.Add(CreatePerson("Jim", "Ruhl", false));

            return people;
        }
    }
}
