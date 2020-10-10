using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Collections.Concurrent;
using System.IO;
using System.Runtime.Remoting;

namespace Lab2.Classes
{
    class Student
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
                    Console.WriteLine("First Name must be more than 2 characters");
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
                    Console.WriteLine("Last Name must be more than 3 characters");
                }
            }
        }
        private string facultyNumber;
        private string FacultyNumber
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
        private Gender Gender { get; set; }

        public Student(/*int id,*/ string firstname, string lastname, string facultyNumber, Gender gender)
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
            this.Gender = gender;
        }

        public void print()
        {
            Console.WriteLine("\nStudent's Details\n-------------------\nFirst Name: {0}\nLast Name: {1}\nFaculty Number: {2}\nGender: {3}", Firstname, Lastname, FacultyNumber,Gender);
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
