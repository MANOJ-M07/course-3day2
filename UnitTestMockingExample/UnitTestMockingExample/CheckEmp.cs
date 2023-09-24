using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestMockingExample
{
    public class CheckEmp
    {
        public virtual bool checkEmp()
        {
            throw new NotImplementedException();
        }
    }

    public class ProcessEmployee
    {
        public bool InsertEmp(CheckEmp objCheck)
        {
            objCheck.checkEmp();

            return true;
        }
    }
}
