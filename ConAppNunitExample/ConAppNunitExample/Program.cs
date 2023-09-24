using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppNunitExample
{
    internal class Program
    {
        public static string SignIn(string userName, string userPwd)
        {
            string msg;
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(userPwd))
            {
                msg = "User Name and Password must not be null";
            }
            else
            {
                if ((userName == "sam") && (userPwd == "sam@1256@1256"))
                {
                    msg = "Signin Success";
                }
                else
                {
                    msg = "Invalid Credential";
                }
            }
            return msg;
        }
        static void Main(string[] args)
        {
        }
    }
}
