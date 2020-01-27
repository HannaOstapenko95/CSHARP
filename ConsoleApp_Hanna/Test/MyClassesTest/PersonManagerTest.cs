using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClasses;

namespace MyClassesTest
{
    [TestClass]
    public class PersonManagerTest
    {
        [TestMethod]
        public void CreatePerson_OfTypeEmployeeTest()
        {
            PersonManager mgr = new PersonManager();
            Person per;
            per = mgr.CreatePerson("Paul", "Sheriff", false);
            Assert.IsInstanceOfType(per, typeof(Employee));
        }
        [TestMethod]
        public void GetEmployeesTest()
        {
            PersonManager mgr = new PersonManager();
            List<Person> employees;
            employees = mgr.GetEmployees();
            CollectionAssert.AllItemsAreInstancesOfType(employees, typeof(Employee));
        }

        [TestMethod]
        public void IsCollectionOfTypeSupervisorsandEmployeeTest()
        {
            PersonManager mgr = new PersonManager();
            List<Person> peopleActual = new List<Person>();
            CollectionAssert.AllItemsAreNotNull(peopleActual);
        }

        [TestMethod]
        public void DoEmployeesExistTest()
        {
            Supervisor super = new Supervisor();
            super.Employees = new List<Employee>();
            super.Employees.Add(new Employee()
            {
                FirstName = "Jim",
                LastName = "Ruhl"
            });
            Assert.IsTrue(super.Employees.Count > 0);
        }
    }
}
