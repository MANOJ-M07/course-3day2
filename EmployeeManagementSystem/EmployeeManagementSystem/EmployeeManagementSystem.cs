using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    [TestFixture]
    internal class EmployeeManagementSystem
    {
        Program obj;
        List<Employee> list;
        [Test]

        public void NotnullTest()
        {
            obj = new Program();
            list = obj.AllEmployees();
            foreach(var item  in list)
            {
                Assert.IsNotNull(item.Id);
                Assert.IsNotNull(item.Name);
                Assert.IsNotNull(item.Designation);
                Assert.IsNotNull(item.Salary);
                Assert.IsNotNull(item.Doj);
            }
        }
        [Test]

        public void EmpDetailsTest()
        {
            int id = 7;
            string name = "Aniket";
            double salary = 65000.50;
            DateTime doj = new DateTime(day: 30, month: 03, year: 2023);
            string desig = "Tester";
            obj = new Program();
            Employee emp = obj.EmpDetails(id);
            Assert.That(salary, Is.EqualTo(emp.Salary).Within(1).Percent);
            Assert.AreEqual(name, emp.Name);
            Assert.AreEqual(desig,emp.Designation);
            Assert.AreEqual(doj, emp.Doj);
        }
    }
}
