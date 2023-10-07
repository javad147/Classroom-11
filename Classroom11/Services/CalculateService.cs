using Classroom11.Helpers.Constans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom11.Services
{
    internal class CalculateService
    {
        public string Calculate(double num1, double num2, string operation) 
        {
            string result;

            switch (operation) 
            {
                case "+":
                    result = (num1 + num2).ToString
                    return result;
                    
                case "-":
                    result = (num1 - num2).ToString
                    return result;

                case "*":
                    result = (num1 * num2).ToString
                    return result;

                case "/":
                    result = (num1 / num2).ToString
                    return result;
                default:
                    result = CalculateNotification.InvalidOperation;
                    return result;
                    
              
             
            }
                 
        }
    }
}
