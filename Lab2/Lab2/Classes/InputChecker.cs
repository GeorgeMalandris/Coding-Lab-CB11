using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab2.Classes
{
    class InputChecker
    {
        public string ValidString(Regex validpattern)
        {
            string input;
            bool flag;
            do
            {
                flag = false;
                input = Console.ReadLine().Trim();
                if (!validpattern.IsMatch(input))
                {
                    Console.WriteLine("You have not entered a valid value.");
                    flag = true;
                }
            } while (flag);
            return input;
        }
        public DateTime ValidDateTimeInput(DateTime? minDate = null, DateTime? maxDate = null)
        {
            if (minDate == null)
                minDate = DateTime.MinValue;
            if (maxDate == null)
                maxDate = DateTime.MaxValue;

            string userInput;
            bool isValidInput;
            DateTime returnDate;
            bool flag = true;
            do
            {
                userInput = Console.ReadLine().Trim();
                isValidInput = DateTime.TryParse(userInput, out returnDate);
                if (!isValidInput)
                    Console.WriteLine("Please give a valid Date.");
                else if (returnDate < minDate)
                    Console.WriteLine("Please give a Date bigger than {0}", minDate);
                else if (returnDate > maxDate)
                    Console.WriteLine("Please give a Date smaller than {0}", maxDate);
                else
                    flag = false;
            } while (flag);
            return returnDate;
        }
        public int IntInput(int minValue = Int32.MinValue, int maxValue = Int32.MaxValue)
        {
            string userInput;
            bool isValidInput;
            int returnNumber;
            bool flag = true;
            do
            {
                userInput = Console.ReadLine().Trim();
                isValidInput = int.TryParse(userInput, out returnNumber);
                if (!isValidInput)
                    Console.WriteLine("Please give a valid value");
                else if (returnNumber < minValue)
                    Console.WriteLine("Please give a number bigger than {0}", minValue);
                else if (returnNumber > maxValue)
                    Console.WriteLine("Please give a number smaller than {0}", maxValue);
                else
                    flag = false;
            } while (flag);
            return returnNumber;
        }
        public double DoubleInput(double minValue = Double.MinValue, double maxValue = Double.MaxValue)
        {
            string userInput;
            bool isValidInput;
            double returnNumber;
            bool flag = true;
            do
            {
                userInput = Console.ReadLine().Trim();
                isValidInput = double.TryParse(userInput, out returnNumber);
                if (!isValidInput)
                    Console.WriteLine("Please give a valid value");
                else if (returnNumber < minValue)
                    Console.WriteLine("Please give a number bigger than {0}", minValue);
                else if (returnNumber > maxValue)
                    Console.WriteLine("Please give a number smaller than {0}", maxValue);
                else
                    flag = false;
            } while (flag);
            return returnNumber;
        }
        public decimal DecimalInput(decimal minValue = Decimal.MinValue, decimal maxValue = Decimal.MaxValue)
        {
            string userInput;
            bool isValidInput;
            decimal returnNumber;
            bool flag = true;
            do
            {
                userInput = Console.ReadLine().Trim();
                isValidInput = decimal.TryParse(userInput, out returnNumber);
                if (!isValidInput)
                    Console.WriteLine("Please give a valid value");
                else if (returnNumber < minValue)
                    Console.WriteLine("Please give a number bigger than {0}", minValue);
                else if (returnNumber > maxValue)
                    Console.WriteLine("Please give a number smaller than {0}", maxValue);
                else
                    flag = false;
            } while (flag);
            return returnNumber;
        }
        public bool TwoChoiceInput(string trueAnswer = "y", string falseAnswer = "n")
        {
            string answer;
            do
            {
                answer = Console.ReadLine().Trim();
            } while (!answer.Equals(trueAnswer, StringComparison.OrdinalIgnoreCase) && !answer.Equals(falseAnswer, StringComparison.OrdinalIgnoreCase));
            return answer.Equals(trueAnswer, StringComparison.OrdinalIgnoreCase) ? true : false;
        }
    }
}
