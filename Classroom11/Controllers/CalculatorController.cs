using Classroom11.Helpers.Constans;
using Classroom11.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom11.Controllers
{
    internal class CalculatorController
    {
        private readonly CalculateService _calculateService;
        public CalculateController() 
        {
            _calculateService = new CalculateService();
        
        }
        public void Calculate() 
        {
            Console.WriteLine("Add first number :");
        Num1: string num1 = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(num1)) 
            {
                Console.WriteLine(CalculateNotification.InvalidOperation);

            }


            double number1;
            bool isTrueNum1 = double.TryParse(num1, out number1);
            if (!isTrueNum1) 
            {
                Console.WriteLine(CalculateNotification.CorrectInputMessage);
                goto Num1;
            
            }


            Console.WriteLine("Please select one operation: + , -, * , /");

            string operation = Console.ReadLine();


            Console.WriteLine("Add second number");
            Num2: string num2 = Console.ReadLine();

            double number2;

            bool isTrueNum2 = double.TryParse(num2, out number2);

            if (!isTrueNum2) 
            {
                Console.WriteLine(CalculateNotification.CorrectInputMessage);
                goto Num2;
            
            
            }

            if (operation == "/" && number2 == 0) 
            {
                Console.WriteLine("Cant be divide by zero");
                goto Num2;



            }


            string result = _calculateService.Calculate(number1, number2, operation);

            Console.WriteLine(result);




        }
    
    }
}
