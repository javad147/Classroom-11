using Classroom11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Classroom11.Services
{
    internal class EmployeeService
    {
        public Employee[] FilterEmployeesBySalar(decimal startSalary, decimal endSalary) 
        {
            Employee[] employees = GetAll();

            Employee[] filtredEmployees = employees.Where(m=>m.Salary > startSalary && m.Salary < endSalary).ToArray()

            return filtredEmployees;    
        }

        private Employee[] GetAll() 
        {
            return new Employee[]
            {
                new Employee
                {
                    Id = 1,
                    Name = "Tunzale",
                    Surname = "Memmedova",
                    Age = 24,
                    Salary = 1000

                },

                new Employee
                {
                    Id = 2,
                    Name = "Semed",
                    Surname = "Huseynov",
                    Age = 27,
                    Salary = 1500

                },

                new Employee
                {
                    Id = 3,
                    Name = "Oruc",
                    Surname = "Mehrabov",
                    Age = 26,
                    Salary = 1300

                },


            };
        }

        public Employee[] SortEmployees(string sortType)
        {
            var employees = GetAll();

            if (sortType == "asc")
                return employees;

            return employees.OrderByDescending(m => m.Salary).ToArray();
        
        }
    }
}
