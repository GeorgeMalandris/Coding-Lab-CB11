using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2.Classes;

namespace Lab2
{
    class Brainy
    {

        List<Student> Students = new List<Student>();
        List<Worker> Workers = new List<Worker>();


        public void addStudent(Student student)
        {
            if (!string.IsNullOrEmpty(student.getName()) && !string.IsNullOrEmpty(student.getLastname()))
            {
                Students.Add(student);
            }
        }
        public void addWorker(Worker worker)
        {
            if (!string.IsNullOrEmpty(worker.getName()) && !string.IsNullOrEmpty(worker.getLastname()))
            {
                Workers.Add(worker);
            }
        }
        public void NumberOfWorkers()
        {
            Console.WriteLine("The total workers are: {0}",Workers.Count());
        }
        //public Student createStudent()
        //{

        //}

        public void Init()
        {
            Student st1 = new Student("George", "Malandris", "4dd4d", Gender.Male);
            st1.print();
            Student st2 = new Student("Panagiotis", "varamentis", "4dd4d46", Gender.Male);
            st2.print();
            Student st3 = new Student("stavros", "", "4dd4d45", Gender.Male);
            st3.print();
            Student st4 = new Student("Aggeliki", "Papantoniou", "d455a55555a", Gender.Female);
            st4.print();

            Worker w1 = new Worker("George", "Malandris", 50, 8, Gender.Male);
            w1.print();
            Worker w2 = new Worker("Panagiotis", "varamentis", 150, 30, Gender.Male);
            w2.print();
            Worker w3 = new Worker("stavros", "", 1, 8, Gender.Male);
            w3.print();
            Worker w4 = new Worker("Aggeliki", "Papantoniou", 100, 0, Gender.Female);
            w4.print();
        }
        
    }
}
