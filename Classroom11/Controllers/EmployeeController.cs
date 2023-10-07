using Classroom11.Models;
using Classroom11.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Classroom11.Controllers
{
    internal class EmployeeController
    {
        private EmployeeService _employeeService;
        public EmployeeController() 
        {
            _employeeService = new EmployeeService()
        
        
        }

        public void GetFilteredEmployees() 
        {
            decimal start = 1000;
            decimal end = 2000;

            foreach (Employee employee in _employeeService.FilterEmployeesBySalar(start, end)) 
            {
                string result = $"{employee.Name} - {employee.Surname} - {employee.Salary} - {employee.Age}";
                Console.WriteLine(result);




            }
                    

            
            
                    
        
        
        }
        public void SortEmployees() 
        {
            Console.WriteLine("Choose one option for sorting:");

            string sortText = Console.ReadLine();

            foreach (Employee employee in _employeeService.SortEmployees(sortText))
            {
                string result = $"{employee.Name} - {employee.Surname} - {employee.Salary} - {employee.Age}";
                Console.WriteLine(result);




            }


        }

    }
}
