using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppNunitExample
{
    [TestFixture]
    internal class SingnInTestClass
    {
        [Test]

        public void SignInTest()
        {
            string empResult = "User Name and Password must not be null";
            string failResult = "Invalid Credential";
            string sResult = "Signin Success";
            Assert.AreEqual(empResult, Program.SignIn(null,null));
            Assert.AreEqual(empResult, Program.SignIn("", ""));
            Assert.AreEqual(failResult, Program.SignIn("ravi", "ravi@123"));
            Assert.AreEqual(sResult, Program.SignIn("sam", "sam@1256@1256"));
        }
    }
}
