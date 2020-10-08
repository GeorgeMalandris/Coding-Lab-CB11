using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Collections.Concurrent;

namespace Lab2.Classes
{
    class Student
    {
        //public int id { get; set; }
        string firstname;
        public string Firstname
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
        string lastname;
        public string Lastname
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
        string facultyNumber;
        public string FacultyNumber
        {
            get
            {
                return facultyNumber;
            }
            set
            {
                Regex pattern = new Regex(@"^\w{5,10}$");
                value.Trim();
                if (pattern.IsMatch(value))
                {
                    facultyNumber = value;
                }
                else
                {
                    Console.WriteLine("Wrong Faculty number.");
                }
            }
        }

        public Student(/*int id,*/ string firstname, string lastname, string facultyNumber)
        {
            if (string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname))
            {
                Console.WriteLine("Student must have a firstname and a lastname");
                return;
            }
            //this.id = id;
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.FacultyNumber = facultyNumber;
        }

        public void print()
        {
            Console.WriteLine("\nStudent's Details\n-------------------\nFirst Name: {0}\nLast Name: {1}\nFaculty Number: {2}\n", Firstname, Lastname, FacultyNumber);
        }
    }
}
