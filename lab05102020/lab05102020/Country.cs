using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05102020
{
    class Country
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Country(int iD, string name)
        {
            ID = iD;
            Name = name;
        }
    }
}
