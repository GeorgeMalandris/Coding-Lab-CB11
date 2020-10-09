using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Classes
{
    class Worker
    {
        //public int id { get; set; }
        private string firstname;
        private string Firstname
        {
            get
            {
                return firstname;
            }
            set
            {
                value.Trim();
                if (value.Length > 2)
                {
                    firstname = value;
                    string firstLetter = firstname[0].ToString().ToUpper();
                    firstname = firstLetter + firstname.Substring(1);
                }
                else
                {
                    Console.WriteLine("More than 2 characters");
                }
            }
        }
        private string lastname;
        private string Lastname
        {
            get
            {
                return lastname;
            }
            set
            {
                value.Trim();
                if (value.Length > 3)
                {
                    lastname = value;
                    string firstLetter = lastname[0].ToString().ToUpper();
                    lastname = firstLetter + lastname.Substring(1);
                }
                else
                {
                    Console.WriteLine("More than 3 characters");
                }
            }
        }
        private decimal weekSalary;
        private decimal WeekSalary
        {
            get
            {
                return weekSalary;
            }
            set
            {
                if (value > 10)
                {
                    weekSalary = value;
                }
                else
                {
                    Console.WriteLine("More than 10");
                }
            }
        }
        private int workHoursPerDay;
        private int WorkHoursPerDay
        {
            get
            {
                return workHoursPerDay;
            }
            set
            {
                if (value >= 1 && value <= 12)
                {
                    workHoursPerDay = value;
                }
                else
                {
                    Console.WriteLine("More than 1 less than 12");
                }
            }
        }
        private decimal SalaryPerHour
        {
            get
            {
                int workHoursPerWeek = WorkHoursPerDay * 5;
                decimal salaryPerHour = 0;
                if(workHoursPerWeek != 0)
                    salaryPerHour = WeekSalary / workHoursPerWeek;
                return salaryPerHour;
            }
        }
        private Gender Gender { get; set; }

        public Worker(/*int id,*/ string firstname, string lastname, decimal weekSalary, int workHoursPerDay, Gender gender)
        {
            if (string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname))
            {
                Console.WriteLine("Worker must have a firstname and a lastname");
                return;
            }
            //this.id = id;
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
            this.Gender = gender;
        }

        public void print()
        {
            Console.WriteLine("\nWorker's Details\n-------------------\nFirst Name: {0}\nLast Name: {1}\nWeek Salary: {2:N2}\nHours Per Day: {3}\nSalary Per Hour: {4:N2}\nGender: {5}", Firstname, Lastname, WeekSalary, WorkHoursPerDay, SalaryPerHour, Gender);
        }
        public string getName()
        {
            return firstname;
        }
        public string getLastname()
        {
            return lastname;
        }
    }
}
