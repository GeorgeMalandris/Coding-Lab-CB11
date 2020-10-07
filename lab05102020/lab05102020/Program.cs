using System;
using System.Collections.Generic;
using System.Configuration;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lab05102020
{
    class Program
    {
        static void Main(string[] args)
        {

            askUser();

        }
        public static void askUser()
        {
            List<Student> students = new List<Student>();
            Console.WriteLine("Would you like to create the students by yourself or use synthetic data?");
            string choice = "";
            do
            {
                Console.WriteLine("Please press 1 for user create or 2 for synthetic.");
                choice = Console.ReadLine();
            } while (choice != "1" && choice != "2");
            if (choice == "1")
                students = createLoop(5);
            else
                students = syntheticStudents();
            foreach  (Student student in students)
            {
                student.printMe();
            }
        }
        public static List<Student> syntheticStudents()
        {
            Student st1 = new Student("George", "Malandris", 32, 1.70, 1800, new DateTime(2020, 6, 6), "6940000000");
            Student st2 = new Student("Tatiana", "Tsitsani", 29, 1.68, 1700, new DateTime(2020, 6, 6), "6941111111");
            Student st3 = new Student("John", "Rizos", 30, 1.72, 2000, new DateTime(2020, 6, 6), "6942222222");
            Student st4 = new Student("Spyros", "Paulatos", 34, 1.74, 1950, new DateTime(2020, 6, 6), "6943333333");
            Student st5 = new Student("Eleutherios", "Malandris", 25, 1.80, 1000, new DateTime(2020, 6, 6), "6944444444");

            List <Student> students = new List<Student> { st1,st2,st3,st4,st5};
            return students;
      
        }
        public static Student createStudent()
        {
            InputChecker checker = new InputChecker();
            Regex namePattern = new Regex(@"^[^0-9\W]{2,}$");
            Console.WriteLine("Please give the Name of the student. (two letters min)");
            string name = checker.ValidString(namePattern);
            Console.WriteLine("Please give the Last Name of the student. (two letters min)");
            string Lastname = checker.ValidString(namePattern);
            Console.WriteLine("Please give the Age of the student.");
            int age = checker.intInput(3);
            Console.WriteLine("Please give the Height of the student.");
            double height = checker.doubleInput(0,2.5);
            Console.WriteLine("Please give the Tuition of the student.");
            double tuition = checker.doubleInput(0, 100000);
            Console.WriteLine("Please give the Date the student starts school. (dd/mm/yyyy)");
            DateTime startDate = checker.validDateTimeInput();
            Console.WriteLine("Please give the Phone of the student.");
            Regex phonePattern = new Regex(@"^[0-9]{10}$");
            string phone = checker.ValidString(phonePattern);
            Student st = new Student(name, Lastname, age, height, tuition, startDate, phone);
            return st;
        }
        public static List<Student> createLoop(int minNumberOfStudents)
        {
            List<Student> students = new List<Student>();
            InputChecker checker = new InputChecker();
            bool choice = true;
            do
            {
                Console.WriteLine("Student creation");
                Student st = createStudent();
                students.Add(st);
                if(minNumberOfStudents < students.Count())
                {
                    Console.WriteLine("Would you like to add another student? (y/n)");
                    choice = checker.yesInput();
                }
            } while (choice);
            return students;
        }
    }
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
        public DateTime validDateTimeInput()
        {
            DateTime dt;
            while (!DateTime.TryParse(Console.ReadLine(), out dt))
            {
                Console.WriteLine("Please give a valid Date.");
            }
            return dt;
        }
        public int intInput(int minValue)
        {
            int input;
            while (!int.TryParse(Console.ReadLine(), out input) || input < minValue)
            {
                Console.WriteLine("Please give an integer bigger than {0}.", minValue);
            }
            return input;
        }
        public double doubleInput(double minValue, double maxValue)
        {
            double input;
            while (!double.TryParse(Console.ReadLine(), out input) || input < minValue || input > maxValue)
            {
                Console.WriteLine("Please give a number between {0} and {1}.", minValue, maxValue);
            }
            return input;
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

    class Student
    {
        public enum conductValues { poor = 10, good = 5, excellent = 1};
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                Fullname = $"{_name} {_lastname}";
            }
        }
        private string _lastname;
        public string Lastname
        {
            get
            {
                return _lastname;
            }
            set
            {
                _lastname = value;
                Fullname = $"{_name} {_lastname}";
            }
        }
        public int Age { get; set; }
        public double Height { get; set; }
        public double Tuition { get; set; }
        public DateTime StartDate { get; set; }
        public string Phone { get; set; }

        Country Country { get; set; }
        CreditCard CreditCard { get; set; }

        private string Fullname { get; set; }
        
        conductValues conduct { get; set; }

        public Student(string name, string lastname, int age, double height, double tuition, DateTime startDate, string phone)
        {
            this.Name = name;
            this.Lastname = lastname;
            this.Age = age;
            this.Height = height;
            this.Tuition = tuition;
            this.StartDate = startDate;
            this.Phone = phone;
        }

        public void printMe()
        {
            Console.WriteLine("\nStudent's Details\n-------------------\nName: {0}\nAge: {1}\nHeight: {2}m\nTuition: {3}\nStarted Date: {4}\nPhone: {5}\n",Fullname,Age,Height.ToString("N2"), Tuition.ToString("N2"), StartDate.ToString("dddd, dd MMMM yyyy"), Phone);
        }
        public void showCountry()
        {
            if(Country.Name.Equals(string.Empty))
                Console.WriteLine("We don't know where the {0} is from.",Fullname);
            else
                Console.WriteLine("{0} is from {2}.",Fullname,Country.Name);
        }
    }

    class Country
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Country(int iD, string name)
        {
            ID = iD;
            Name = name;
        }
    }
    class CreditCard
    {
        public int Id { get; set; }
        public string CardName { get; set; }
        public int CardNumber { get; set; }
        public bool IsActive { get; set; }
        public DateTime ExpirationDate { get; set; }
        public CreditCard(int id, string cardName, int cardNumber, bool isActive, DateTime expirationDate)
        {
            Id = id;
            CardName = cardName;
            CardNumber = cardNumber;
            IsActive = isActive;
            ExpirationDate = expirationDate;
        }

    }
}
