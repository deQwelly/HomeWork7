using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7_2_
{
    class ViceDevelopers : HeadDevelopers
    {
        public ViceDevelopers(string name) 
        {
            this.name = name;
            rang = 2;
            department = Departments.IT;
        }
        protected ViceDevelopers() { }
    }
}
