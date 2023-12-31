﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    internal class Program
    {
        public List<Employee> AllEmployees()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee()
                {
                    Id = 1,
                    Name = "Sam",
                    Salary = 98000.50,
                    Designation = "Programmer",
                    Doj = new DateTime(day:24,month:11,year:2019)
                },

                new Employee()
                {
                    Id = 2,
                    Name = "Ravi",
                    Salary = 78000.50,
                    Designation = "Developer",
                    Doj = new DateTime(day:24,month:01,year:2018)
                },

                new Employee()
                {
                    Id = 7,
                    Name = "Aniket",
                    Salary = 65000.50,
                    Designation = "Tester",
                    Doj = new DateTime(day:30,month:03,year:2023)
                },

                new Employee()
                {
                    Id = 4,
                    Name = "Viz",
                    Salary = 86000.50,
                    Designation = "Developer",
                    Doj = new DateTime(day:12,month:02,year:2023)
                }
            };
            return employees;
        }

        public Employee EmpDetails(int id)
        {
            List<Employee> list = AllEmployees();

            Employee emp = list.SingleOrDefault(e => e.Id == id);
            return emp;
            
        }
        static void Main(string[] args)
        {
        }
    }
}
