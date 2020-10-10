using Lab2.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
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
            int number = br.NumberOfWorkers();

            br.CreateStudent();
            br.CreateWorker();

            foreach (var item in br.GetStudents())
            {
                item.print();
            }

            foreach (var item in br.GetWorkers())
            {
                item.print();
            }



        }
    }
}
