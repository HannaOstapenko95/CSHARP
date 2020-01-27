using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClasses;

namespace MyClassesTest
{
    /// <summary>
    /// Summary description for AssertClassTest
    /// </summary>
    [TestClass]
    public class AssertClassTest
    {
        #region AreEqual/AreNotEqual Tests
        [TestMethod]
        [Owner("Hanna OstapenkoS")]
        public void AreEqualTest()
        {
            string str1 = "Hanna";
            string str2 = "Hanna";
            Assert.AreEqual(str1, str2); //Case-sensitive search
        }

        [TestMethod]
        [Owner("Hanna OstapenkoS")]
        [ExpectedException(typeof(AssertFailedException))]
        public void AreEqualCaseSensitiveTest()
        {
            string str1 = "Hanna";
            string str2 = "hanna";
            Assert.AreEqual(str1, str2, false); //Not Case-sensitive search
        }

        [TestMethod]
        [Owner("Hanna OstapenkoS")]
        public void AreNotEqualTest()
        {
            string str1 = "Hanna";
            string str2 = "Olena";
            Assert.AreNotEqual(str1, str2); //Case-sensitive search
        }
        #endregion
        #region AreSame/AreNotSame Tests
        [TestMethod]
        [Owner("Hanna OstapenkoS")]
        public void AreSameTest()
        {
            FileProcess x = new FileProcess();
            FileProcess y = x;
            Assert.AreSame(x, y); 
        }

        [TestMethod]
        [Owner("Hanna OstapenkoS")]
        public void AreNotSameTest()
        {
            FileProcess x = new FileProcess();
            FileProcess y = new FileProcess();
            Assert.AreNotSame(x, y);
        }
        #endregion
        #region IsInstanceofType Test
        [TestMethod]
        [Owner("HAOK")]
        public void IsInstanceOfTypeTest()
        {
            PersonManager mgr = new PersonManager();
            Person per;
            per = mgr.CreatePerson("Hanna", "Olena", true);
            Assert.IsInstanceOfType(per, typeof(Supervisor));
        }
        #endregion
        #region IsNull Test
        [TestMethod]
        [Owner("HAOK")]
        public void IsNullTest()
        {
            PersonManager mgr = new PersonManager();
            Person per;
            per = mgr.CreatePerson("", "Olena", true);
            Assert.IsNull(per);
        }
        #endregion
    }
}
