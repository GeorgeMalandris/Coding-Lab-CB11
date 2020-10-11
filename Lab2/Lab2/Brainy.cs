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

        public static void Init() //This is the Menu Area
        {
            bool flag = true; //the bool to determine if we want to continue with actions or exit
            do
            {
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Add Worker");
                Console.WriteLine("3. Add Synthetic Data");
                Console.WriteLine("4. Print Worker Count");
                Console.WriteLine("5. Print Students");
                Console.WriteLine("6. Print Workers");
                Console.WriteLine("7. Exit App");
                Helper.HandleAction("Pick a number to make an action");
            } while (flag);
            Console.WriteLine("Bye bye!");
        }

        public void SyntheticData()
        {
            Student st1 = new Student("George", "Malandris", "4dd4d", Gender.Male);
            Student st2 = new Student("Panagiotis", "varamentis", "4dd4d46", Gender.Male);
            Student st3 = new Student("stavros", "", "4dd4d45", Gender.Male);
            Student st4 = new Student("Aggeliki", "Papantoniou", "d455a55555a", Gender.Female);
            Worker w1 = new Worker("George", "Malandris", 50, 8, Gender.Male);
            Worker w2 = new Worker("Panagiotis", "varamentis", 150, 30, Gender.Male);
            Worker w3 = new Worker("stavros", "", 1, 8, Gender.Male);
            Worker w4 = new Worker("Aggeliki", "Papantoniou", 100, 0, Gender.Female);
        }
        
    }
}
