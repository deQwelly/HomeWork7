using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7_2_
{
    class HeadAccounting : FinantialDirector
    {
        public HeadAccounting(string name)
        {
            this.name = name;
            rang = 5;
            department = Departments.Financial;
        }

        public void GiveSalary()
        {
            Console.WriteLine($"{name} распорядился выплатить всем зарплату");
        }

        public void GiveSalary(object o)
        {
            Employee emp = o as Employee;
            if (emp != null)
            {
                Console.WriteLine($"{name} выплатил'а зарплату для {emp.Name}");
            }
            else
            {
                Console.WriteLine("Такого сотрудника нет");
            }
        }
    }
}
