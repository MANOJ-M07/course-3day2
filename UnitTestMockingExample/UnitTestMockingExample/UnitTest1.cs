using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace UnitTestMockingExample
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EqualTest()
        {
            int num1 = 15;
            Assert.AreEqual(num1, 15);  
        }

        [TestMethod]
        public void MockTest()
        {
            //Mock<CheckEmp>chk = new Mock<CheckEmp> ();
            //chk.Setup(x=>x.checkEmp()).Returns(true);
            //    CheckEmp chk = new CheckEmp();
            //    ProcessEmployee process = new ProcessEmployee ();
            //    Assert.AreEqual(true,process.InsertEmp(chk));

            Mock<CheckEmp> chk = new Mock<CheckEmp>();
            chk.Setup(x=>x.checkEmp()).Returns(true);
            ProcessEmployee process = new ProcessEmployee();
            Assert.AreEqual(true,process.InsertEmp(chk.Object));
        }
    }
}
