using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Lab2.Classes;

namespace Lab2
{
    class Brainy
    {

        private List<Student> Students = new List<Student>();
        private List<Worker> Workers = new List<Worker>();

        public IList<Student> GetStudents()
        {
            IList<Student> readOnlyList = Students.AsReadOnly();
            return readOnlyList;
        }
        public IList<Worker> GetWorkers()
        {
            IList<Worker> readOnlyList = Workers.AsReadOnly();
            return readOnlyList;
        }

        public int NumberOfWorkers()
        {
            int numberOfWorkers = Workers.Count();
            Console.WriteLine("The total workers are: {0}", numberOfWorkers);
            return numberOfWorkers;
        }

        public void CreateStudent()
        {
            InputChecker checker = new InputChecker();
            Regex namePattern = new Regex(@"^[^0-9\W]{3,}$");
            Console.WriteLine("Please give the Name of the student. (two letters min)");
            string name = checker.ValidString(namePattern);

            Regex lastNamePattern = new Regex(@"^[^0-9\W]{4,}$");
            Console.WriteLine("Please give the Last Name of the student. (three letters min)");
            string Lastname = checker.ValidString(lastNamePattern);

            Console.WriteLine("Please give the Faculty Number of the student.");
            Regex facultyNumberPattern = new Regex(@"^\w{5,10}$");
            string facultyNumber = checker.ValidString(facultyNumberPattern);

            Console.WriteLine("Please choose the Gender of the student by typing (m) for Male or (f) for Female.");
            bool genderChoice = checker.TwoChoiceInput("m", "f");
            Gender gender = Gender.Female;
            if (genderChoice)
                gender = Gender.Male;

            Student student = new Student(name, Lastname, facultyNumber, gender);
            AddStudent(student);
        }
        public void CreateWorker()
        {
            InputChecker checker = new InputChecker();
            Regex namePattern = new Regex(@"^[^0-9\W]{2,}$");
            Console.WriteLine("Please give the Name of the worker. (two letters min)");
            string name = checker.ValidString(namePattern);

            Console.WriteLine("Please give the Last Name of the worker. (three letters min)");
            string Lastname = checker.ValidString(namePattern);

            Console.WriteLine("Please give the Weekly Salary of the worker.");
            decimal weekSalary = checker.DecimalInput(10.001m);

            Console.WriteLine("Please give the work hours per day of the worker.");
            int workHoursPerDay = checker.IntInput(1, 12);

            Console.WriteLine("Please choose the Gender of the worker by typing (m) for Male or (f) for Female.");
            bool genderChoice = checker.TwoChoiceInput("m", "f");
            Gender gender = Gender.Female;
            if (genderChoice)
                gender = Gender.Male;

            Worker worker = new Worker(name, Lastname, weekSalary, workHoursPerDay, gender);
            AddWorker(worker);
        }
        private void AddStudent(Student student)
        {
            if (!string.IsNullOrEmpty(student.getName()) && !string.IsNullOrEmpty(student.getLastname()))
            {
                Students.Add(student);
            }
        }
        private void AddWorker(Worker worker)
        {
            if (!string.IsNullOrEmpty(worker.getName()) && !string.IsNullOrEmpty(worker.getLastname()))
            {
                Workers.Add(worker);
            }
        }

        public void Init()
        {
            Student st1 = new Student("George", "Malandris", "4dd4d", Gender.Male);
            Student st2 = new Student("Panagiotis", "varamentis", "4dd4d46", Gender.Male);
            Student st3 = new Student("stavros", "", "4dd4d45", Gender.Male);
            Student st4 = new Student("Aggeliki", "Papantoniou", "d455a55555a", Gender.Female);

            List<Student> syntheticStudents = new List<Student> { st1, st2, st3, st4 };

            foreach (Student student in syntheticStudents)
            {
                AddStudent(student);
            }


            Worker w1 = new Worker("George", "Malandris", 50, 8, Gender.Male);
            Worker w2 = new Worker("Panagiotis", "varamentis", 150, 30, Gender.Male);
            Worker w3 = new Worker("stavros", "", 1, 8, Gender.Male);
            Worker w4 = new Worker("Aggeliki", "Papantoniou", 100, 0, Gender.Female);

            List<Worker> syntheticWorkers = new List<Worker> { w1, w2, w3, w4 };

            foreach (Worker worker in syntheticWorkers)
            {
                AddWorker(worker);
            }
        }
    }
}
