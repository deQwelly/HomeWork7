using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7_2_
{
    class Developers : ViceDevelopers
    {
        public Developers(string name)
        {
            this.name = name;
            rang = 1;
            department = Departments.IT;
        }
    }
}
