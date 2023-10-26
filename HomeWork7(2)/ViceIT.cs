using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7_2_
{
    class ViceIT : HeadIT
    {
        public ViceIT(string name) 
        {
            this.name = name;
            rang = 4;
            department = Departments.IT;
        }
        protected ViceIT() { }
    }
}
