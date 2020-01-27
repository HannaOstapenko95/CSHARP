using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace MyClassesTest
{
    [TestClass]
    public class StringAssertClassTest
    {
        [TestMethod]
        [Owner("HAOK")]
        public void ContainsTest()
        {
            string str1 = "John Kuhn";
            string str2 = "Kuhn";
            StringAssert.Contains(str1, str2);
        }

        [TestMethod]
        [Owner("HAOK")]
        public void StartWithTest()
        {
            string str1 = "All Lower Case";
            string str2 = "All Lower";
            StringAssert.StartsWith(str1, str2);
        }

        [TestMethod]
        [Owner("HAOK")]
        public void IsAllLowerCaseTest()
        {
            Regex r = new Regex(@"^([^A-Z])+$");
            StringAssert.Matches("all lower case", r);
        }

        [TestMethod]
        [Owner("HAOK")]
        public void IsNotAllLowerCaseTest()
        {
            Regex r = new Regex(@"^([^A-Z])+$");
            StringAssert.DoesNotMatch("All Lower Case", r);
        }
    }
}
