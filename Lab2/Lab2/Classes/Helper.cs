using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Classes
{
    class Helper
    {
        public static void HandleAction(string msg)
        {
            string str;
            int num;
            do
            {
                Console.WriteLine(msg);
                str = Console.ReadLine();
            } while (!int.TryParse(str, out num) && num != 1 && num != 2 && num != 3 && num != 4 && num != 5 && num != 6 && num != 7);
        }

        public static string YesOrNo(string msg)
        {
            string str;
            do
            {
                Console.WriteLine(msg);
                str = Console.ReadLine().ToUpper();
            } while (str != "Y" && str != "N");
            return str;
        }
    }
}
