using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClasses;

namespace MyClassesTest
{
    [TestClass]
    public class CollectionAssertClassTest
    {
        /// <summary>
        /// We want this test to fail to illustrate Equality means. Because these are different objects
        /// </summary>
        [TestMethod]
        public void AreCollectionsEqualFailsBecauseNoComparerTest()
        {
            PersonManager mgr = new PersonManager();
            List<Person> peopleExpected = new List<Person>();
            List<Person> peopleActual = new List<Person>();
            peopleExpected.Add(new Person() { FirstName = "Paul", LastName = "Sheriff" });
            peopleExpected.Add(new Person() { FirstName = "John", LastName = "Kuhn" });
            peopleExpected.Add(new Person() { FirstName = "Jim", LastName = "Ruhl" });
            peopleActual = mgr.GetPeople();
            CollectionAssert.AreEqual(peopleExpected, peopleActual);
        }

        [TestMethod]
        public void AreCollectionsEqualWithComparerTestt()
        {
            PersonManager mgr = new PersonManager();
            List<Person> peopleExpected = new List<Person>();
            List<Person> peopleActual = new List<Person>();
            peopleExpected.Add(new Person() { FirstName = "Paul", LastName = "Sheriff" });
            peopleExpected.Add(new Person() { FirstName = "John", LastName = "Kuhn" });
            peopleExpected.Add(new Person() { FirstName = "Jim", LastName = "Ruhl" });
            peopleActual = mgr.GetPeople();
            //Provide your own "Comparer" to determine equality
            CollectionAssert.AreEqual(peopleExpected, peopleActual,
                Comparer<Person>.Create((x,y)=>
                x.FirstName == y.FirstName && x.LastName == y.LastName ? 0 : 1));
        }

        [TestMethod]
        public void AreCollectionsEqualTest()
        {
            PersonManager mgr = new PersonManager();
            List<Person> peopleExpected = new List<Person>();
            List<Person> peopleActual = new List<Person>();
            
            peopleActual = mgr.GetPeople();
            peopleExpected = peopleActual;
            //The sane collection, the same object
            CollectionAssert.AreEqual(peopleExpected, peopleActual);
        }

        [TestMethod]
        public void AreCollectionsEquivalentTest()
        {
            PersonManager mgr = new PersonManager();
            List<Person> peopleExpected = new List<Person>();
            List<Person> peopleActual = new List<Person>();

            peopleActual = mgr.GetPeople();
            //Add same Person objects to new collection, but in a different order
            peopleExpected.Add(peopleActual[1]);
            peopleExpected.Add(peopleActual[2]);
            peopleExpected.Add(peopleActual[0]);
            //Checks for same objects, but in any order
            CollectionAssert.AreEquivalent(peopleExpected, peopleActual);
        }

        [TestMethod]
        public void IsCollectionTypeTest()
        {
            PersonManager mgr = new PersonManager();
            List<Person> peopleActual = new List<Person>();

            peopleActual = mgr.GetSupervisors();

            CollectionAssert.AllItemsAreInstancesOfType(peopleActual, typeof(Supervisor));
        }
    }
}
