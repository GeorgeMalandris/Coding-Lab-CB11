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
            int age = checker.intInput(3,120);
            Console.WriteLine("Please give the Height of the student.");
            double height = checker.doubleInput(0,2.5);
            Console.WriteLine("Please give the Tuition of the student.");
            double tuition = checker.doubleInput(0, 100000);
            Console.WriteLine("Please give the Date the student starts school. (dd/mm/yyyy)");
            DateTime startDate = checker.validDateTimeInput(new DateTime(2000,01,01),new DateTime(2040,01,01));
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
}
