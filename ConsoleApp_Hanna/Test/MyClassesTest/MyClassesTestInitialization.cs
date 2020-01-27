using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyClassesTest
{
    /// <summary>
    /// Assembly Initialize and Cleanup Methods
    /// </summary>
    [TestClass]
    public class MyClassesTestInitialization
    {
        [AssemblyInitialize] //attributes
        public static void AssemblyInitialize(TestContext tc)
        {
            tc.WriteLine("In the Assembly Initialize Method.");
            //TODO: Create resources needed for test
        }
        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            //TODO: Cleanup resources used by test
        }

       
    }
}
