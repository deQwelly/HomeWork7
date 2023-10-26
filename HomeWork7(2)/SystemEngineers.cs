using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7_2_
{
    class SystemEngineers : ViceSystemEngineers
    {
        public SystemEngineers(string name)
        {
            this.name = name;
            rang = 1;
            department = Departments.IT;
        }
        protected SystemEngineers() { }

        public void CheckTechnical()
        {
            Console.WriteLine($"{name} проверяет технику");
        }
    }
}
