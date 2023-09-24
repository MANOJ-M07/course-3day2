using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    
    [TestFixture]
    public class SampleCollectionTest
    {
        List<string> majorcolors = new List<string> {"fuchisa","magenta", "red", "white", "pink", "blue","yellow" };
        List<string> colors = new List<string> { "red", "white", "pink", "blue" };
        [Test]
        public void ContainsTest()
        {
            Assert.That(colors.Contains("red"), Is.True);
            Assert.That(colors, Has.Member("red"));
        }

        [Test]
        public void NotContainsTest()
        {
            Assert.That(colors, Has.No.Member("yellow"));
        }

        [Test]
        public void SupersetTest()
        {
            Assert.That(majorcolors, Is.SupersetOf(colors));
        }

        [Test]
        public void SubsetTest()
        {
            Assert.That(colors, Is.SubsetOf(majorcolors));
        }
    }
}
