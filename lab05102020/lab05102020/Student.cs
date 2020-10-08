using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05102020
{
    class Student
    {
        private string Name { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        public double Tuition { get; set; }
        public DateTime StartDate { get; set; }
        public string Phone { get; set; }
        public string Fullname
        {
            get
            {
                return $"{Name} {Lastname}";
            }
        }
        Country Country { get; set; }
        
        Conduct StudentConduct { get; set; }

        public Student(string name, string lastname, int age, double height, double tuition, DateTime startDate, string phone, Country country, Conduct studentContact)
        {
            this.Name = name;
            this.Lastname = lastname;
            this.Age = age;
            this.Height = height;
            this.Tuition = tuition;
            this.StartDate = startDate;
            this.Phone = phone;
            this.Country = country;
            this.StudentConduct = studentContact;
        }
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
        public Student(string name, string lastname, int age, string phone)
        {
            this.Name = name;
            this.Lastname = lastname;
            this.Age = age;
            this.Phone = phone;
        }


        public void printMe()
        {
            Console.WriteLine("\nStudent's Details\n-------------------\nName: {0}\nAge: {1}\nHeight: {2}m\nTuition: {3}\nStarted Date: {4}\nPhone: {5}\n", Fullname, Age, Height.ToString("N2"), Tuition.ToString("N2"), StartDate.ToString("dddd, dd MMMM yyyy"), Phone);
        }
        public void showCountry()
        {
            if (Country.Name.Equals(string.Empty))
                Console.WriteLine("We don't know where the {0} is from.", Fullname);
            else
                Console.WriteLine("{0} is from {2}.", Fullname, Country.Name);
        }
        public void raiseTuition()
        {
            switch (StudentConduct)
            {
                case Conduct.poor:
                    Tuition *= 1.1;
                    break;
                case Conduct.good:
                    Tuition *= 1.05;
                    break;
                case Conduct.excellent:
                    Tuition *= 1.01;
                    break;
                default:
                    Tuition *= 1;
                    break;
            }
        }
    }
}
