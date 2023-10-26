using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7_2_
{
    class FinantialDirector : GeneralDirector
    {
        public FinantialDirector(string name)
        {
            this.name = name;
            rang = 6;
            department = Departments.Financial;
        }
        protected FinantialDirector() { }
    }
}
