using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace lab05102020
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
        public DateTime validDateTimeInput(DateTime? minDate = null, DateTime? maxDate = null)
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
                userInput = Console.ReadLine();
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
        public int intInput(int minValue = Int32.MinValue, int maxValue = Int32.MaxValue)
        {
            string userInput;
            bool isValidInput;
            int returnNumber;
            bool flag = true;
            do
            {
                userInput = Console.ReadLine();
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
        public double doubleInput(double minValue = Double.MinValue, double maxValue = Double.MaxValue)
        {
            string userInput;
            bool isValidInput;
            double returnNumber;
            bool flag = true;
            do
            {
                userInput = Console.ReadLine();
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
        public bool yesInput()
        {
            string answer;
            do
            {
                answer = Console.ReadLine();
            } while (!answer.Equals("y", StringComparison.OrdinalIgnoreCase) && !answer.Equals("n", StringComparison.OrdinalIgnoreCase));
            return answer.Equals("y", StringComparison.OrdinalIgnoreCase) ? true : false;
        }
    }
}
