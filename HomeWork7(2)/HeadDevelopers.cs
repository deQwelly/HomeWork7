using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7_2_
{
    class HeadDevelopers : ViceIT
    {
        public HeadDevelopers(string name)
        {
            this.name = name;
            rang = 3;
            department = Departments.IT;
        }
        protected HeadDevelopers() { }

        public void Programming()
        {
            Console.WriteLine($"{name} программирует");
        }
    }
}
