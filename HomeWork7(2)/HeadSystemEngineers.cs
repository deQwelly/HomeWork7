using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7_2_
{
    class HeadSystemEngineers : ViceIT
    {
        public HeadSystemEngineers(string name)
        {
            this.name = name;
            rang = 3;
            department = Departments.IT;
        }
        protected HeadSystemEngineers() { }
    }
}
