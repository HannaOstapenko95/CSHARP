using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClasses;
using System.Configuration;
using System.IO;
namespace MyClassesTest
{
    [TestClass] //special attributes
    public class FileProcessTest
    {
        private const string BAD_FILE_NAME = @"U:\BadFileName.txt";
        private string _GoodFileName; //takes value from config file
        #region Class Initialize and Cleanup
        [ClassInitialize]
        public static void ClassInitialize(TestContext tc)
        {
            tc.WriteLine("In the Class Initialize.");
        }
        [ClassCleanup]
        public static void ClassCleanup()
        {
        }
        #endregion
        #region Test Initialize and Cleanup
        [TestInitialize]
        public void TestInitialize()
        {
            if (TestContext.TestName.StartsWith ("FileNameDoesExist"))
            {
                SetGoodFileName();
                if (!string.IsNullOrEmpty(_GoodFileName))
                {
                    TestContext.WriteLine("Creating File: " + _GoodFileName);
                    File.AppendAllText(_GoodFileName, "SomeText");
                }
            }
        }
        [TestCleanup]
        public void TestCleanup()
        {
            if (TestContext.TestName.StartsWith ("FileNameDoesExist"))
            {
                if (!string.IsNullOrEmpty(_GoodFileName))
                {
                    TestContext.WriteLine("Deleting File: " + _GoodFileName);
                    File.Delete(_GoodFileName);
                }
            }
        }
        #endregion
        public TestContext TestContext { get; set; }

        [TestMethod]
        [Description("Check to see if a file does exists.")]
        [Owner("Hanna Ostapenko")]
        [Priority(0)]
        [TestCategory("NoException")]
        //[Ignore()] //For skipping tests
        public void FileNameDoesExist()
        {
            //Arrange
            FileProcess fp = new FileProcess();
            bool fromCall;
            //Act
            /*WAY 1 
            fromCall = fp.FileExists((@"U:\C#-TRAINING\app\HAOK-master\ConsoleApp2\Test\MyClassesTest\GoodFile.txt"));
            Assert.IsTrue(fromCall);*/

            /*WAY 2 Using config file
            SetGoodFileName();
            File.AppendAllText(_GoodFileName, "SomeText");
            fromCall = fp.FileExists(_GoodFileName);
            File.Delete(_GoodFileName);
            Assert.IsTrue(fromCall);*/

            /*Way 3 Using TestContext
            SetGoodFileName();
            TestContext.WriteLine("Creating a file " + _GoodFileName);
            File.AppendAllText(_GoodFileName, "SomeText");
            TestContext.WriteLine("Testing a file " + _GoodFileName);
            fromCall = fp.FileExists(_GoodFileName);
            TestContext.WriteLine("Deleting a file " + _GoodFileName);
            File.Delete(_GoodFileName);
            Assert.IsTrue(fromCall);*/

            //Way 4 Using TestInitializer
            TestContext.WriteLine("Testing a file " + _GoodFileName);
            fromCall = fp.FileExists(_GoodFileName);
            Assert.IsTrue(fromCall);

            //Like TODO: Assert.Inconclusive();
        }
        [TestMethod]
        [Timeout(3000)]
        public void SimulateTimeout()
        {
            System.Threading.Thread.Sleep(2000);
        }

        private const string FILE_NAME = @"FileToDeploy.txt";
        [TestMethod]
        [Owner("Hanna Ostapenko")]
        [DeploymentItem(FILE_NAME)]
        public void FileNameDoesExistUsingDeploymentItem()
        {
            FileProcess fp = new FileProcess();
            string fileName;
            bool fromCall;
            fileName = TestContext.DeploymentDirectory + @"\" + FILE_NAME;
            TestContext.WriteLine("Checking file: " + fileName);
            fromCall = fp.FileExists(fileName);
            Assert.IsTrue(fromCall);
        }

        [TestMethod]
        [Description("Check to see if a file does NOT exist.")]
        [Owner("Hanna Ostapenko")]
        [Priority(0)]
        [TestCategory("NoException")]
        public void FileNameDoesNotExist()
        {
            //Arrange
            FileProcess fp = new FileProcess();
            bool fromCall;
            //Act
            fromCall = fp.FileExists(BAD_FILE_NAME);
            //Assert
            Assert.IsFalse(fromCall);
            //Assert.Inconclusive();
        }

        public void SetGoodFileName()
        {
            _GoodFileName = ConfigurationManager.AppSettings["GoodFileName"];
            if (_GoodFileName.Contains("[AppPath]"))
            {
                _GoodFileName =_GoodFileName.Replace("[AppPath]",
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            }
        }
        [TestMethod]
        public void FileNameDoesExistSimpleMessage()
        {
            //Arrange
            FileProcess fp = new FileProcess();
            bool fromCall;
            //Act
            fromCall = fp.FileExists(_GoodFileName);
            //Assert
            Assert.IsTrue(fromCall, "File Does Exist.");
        }

        [TestMethod]
        public void FileNameDoesExistMessageWithFormatting()
        {
            //Arrange
            FileProcess fp = new FileProcess();
            bool fromCall;
            //Act
            fromCall = fp.FileExists(_GoodFileName);
            //Assert
            Assert.IsTrue(fromCall, "File {0} Does Exist.", _GoodFileName);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        [Owner("Hanna Ostapenko")]
        [Priority(1)]
        [TestCategory("Exception")]
        public void FileNameNullOrEmpty_ThrowsArgumentNullException()
        {
            FileProcess fp = new FileProcess();
            fp.FileExists("");
           // Assert.Inconclusive();
        }
        [TestMethod]
        [Owner("Hanna Ostapenko")]
        [Priority(1)]
        [TestCategory("Exception")]
        public void FileNameNullOrEmpty_ThrowsArgumentNullException_UseTryCatch()
        {
            FileProcess fp = new FileProcess();
            try
            {
                fp.FileExists("");
            }
            catch (ArgumentException)
            {//The test was a success
                return;
            }
            Assert.Fail("Call to FileExists did NOT throw an ArgumentNullException.");
        }
    }
}
