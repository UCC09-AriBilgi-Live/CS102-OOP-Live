using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_AccessModifiers
{
    class clsStudent
    {
        private string stuname = "Ümit K.";

        public void getName()
        {
            Console.WriteLine($"Hello from student class...Name : {stuname}");
        }
    }
}
