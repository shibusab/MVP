using MVP.Code.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using MVP.Code.Domain;
using System.Collections.Generic;

namespace MVPTestProject
{
    
    
    /// <summary>
    ///This is a test class for InvoiceRepositoryTest and is intended
    ///to contain all InvoiceRepositoryTest Unit Tests
    ///</summary>
    [TestClass()]
    public class InvoiceRepositoryTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for FindAll
        ///</summary>
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("%PathToWebRoot%\\MVP\\MVP", "/")]
        [UrlToTest("http://localhost:62415/")]
        public void FindAllTest()
        {
            InvoiceRepository target = new InvoiceRepository();
            List<Invoice> actual;
            actual = target.FindAll();
            string actualCount =string.Format("Actual Count is {0}", actual.Count); 
            Assert.AreEqual(actual.Count,4 , actualCount );
           // Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for InvoiceRepository Constructor
        ///</summary>
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("%PathToWebRoot%\\MVP\\MVP", "/")]
        [UrlToTest("http://localhost:62415/")]
        public void InvoiceRepositoryConstructorTest()
        {
            InvoiceRepository target = new InvoiceRepository();
            Assert.IsNotNull (target);
        //    Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
