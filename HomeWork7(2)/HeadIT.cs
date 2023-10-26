using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7_2_
{
    class HeadIT : AutomatisationDirector
    {
        public HeadIT(string name)
        {
            this.name = name;
            rang = 5;
            department = Departments.IT;
        }
        protected HeadIT() { }
    }
}
