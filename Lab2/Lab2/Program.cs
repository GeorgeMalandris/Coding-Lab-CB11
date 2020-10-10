using Lab2.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Brainy br = new Brainy();
            br.Init();

            string exitFlag = "";
            do
            {
                Console.Clear();
                exitFlag = menu(br);
            } while (!exitFlag.Equals("exit"));
            
        }
        public static string menu(Brainy br)
        {
            string userChoice = "";
            bool validChoice = false;
            do
            {
                Regex validPattern = new Regex(@"(^exit$)|(^[1-5]${1})");
                Console.WriteLine("Welcome\n\nWhat would you like to do?");
                Console.WriteLine("1.Add a student\n2.Add a worker\n3.See all students\n4.See all workers\n5.See the number of the workers\n\nEXIT");
                userChoice = Console.ReadLine().ToLower().Trim();
                if (validPattern.IsMatch(userChoice))
                    validChoice = true;
            } while (!validChoice);
            switch (userChoice)
            {
                case "1":
                    br.CreateStudent();
                    break;
                case "2":
                    br.CreateWorker();
                    break;
                case "3":
                    foreach (var item in br.GetStudents())
                    {
                        item.print();
                    }
                    Console.WriteLine("\nPress any key to continue..");
                    Console.ReadKey();
                    break;
                case "4":
                    foreach (var item in br.GetWorkers())
                    {
                        item.print();
                    }
                    Console.WriteLine("\nPress any key to continue..");
                    Console.ReadKey();
                    break;
                case "5":
                    br.NumberOfWorkers();
                    Console.WriteLine("\nPress any key to continue..");
                    Console.ReadKey();
                    break;
                case "exit":
                    break;
                default:
                    Console.WriteLine("The choice isn't supported");
                    break;
            }
            return userChoice;
        }
    }
}
