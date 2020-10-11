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

            Console.WriteLine("Lab2 CB11 C#");

            string str = Helper.YesOrNo("Proceed to menu? Y/N");

            if (str == "Y")
                Brainy.Init();
            else
                Console.WriteLine("Bye bye!");

        }
    }
}
