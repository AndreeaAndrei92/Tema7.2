using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Group
    {
        public Group(int number, string name)
        {
            this.GroupNumber = number;
            this.DepartamentName = name;
        }

        public int GroupNumber { get; private set; }
        public string DepartamentName { get; private set; }


    }
}
