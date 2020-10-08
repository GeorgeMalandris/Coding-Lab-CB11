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
            Student st1 = new Student("George","Malandris","4dd4d");
            st1.print();
            Student st2 = new Student("Panagiotis", "varamentis", "4dd4d46");
            st2.print();
            Student st3 = new Student("stavros", "", "4dd4d45");
            st3.print();
            Student st4 = new Student("Aggeliki", "Papantoniou", "d455a55555a");
            st4.print();

            Worker w1 = new Worker("George", "Malandris", 50, 8);
            w1.print();
            Worker w2 = new Worker("Panagiotis", "varamentis", 150,30);
            w2.print();
            Worker w3 = new Worker("stavros", "", 1,8);
            w3.print();
            Worker w4 = new Worker("Aggeliki", "Papantoniou", 100,0);
            w4.print();
        }
    }
}
