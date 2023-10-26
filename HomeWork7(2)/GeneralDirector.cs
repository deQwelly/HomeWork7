using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7_2_
{
    class GeneralDirector : Employee
    {
        public GeneralDirector(string name)
        {
            this.name = name;
            rang = 7;
            department = Departments.HeadCompany;
        }
        protected GeneralDirector() { }

        public void SignPapers()
        {
            Console.WriteLine($"{name} принялся подписывать бумаги");
        }

        public void Kikc(object o)
        {
            if (rang >= 2)
            {
                Employee emp = o as Employee;
                if (emp != null)
                {
                    if (department == Departments.HeadCompany | department == emp.Department)
                    {
                        Console.WriteLine($"{name} уволил'а {emp.Name}");
                    }
                    else
                    {
                        Console.WriteLine($"{name} не может лезть в дела не своего отдела");
                    }
                }
                else
                {
                    Console.WriteLine("Такого сотрудника нет");
                }
            }
            else { Console.WriteLine($"У {name} недостаточно прав для увольнения"); }
        }

        public void GiveScolding(object o)
        {
            if (rang >= 2)
            {
                Employee emp = o as Employee;
                if (emp != null)
                {
                    if (department == Departments.HeadCompany | department == emp.Department)
                    {
                        Console.WriteLine($"{name} дал'а нагоняй {emp.Name}");
                    }
                    else
                    {
                        Console.WriteLine($"{name} не может лезть в дела не своего отдела");
                    }
                }
                else
                {
                    Console.WriteLine("Такого сотрудника нет");
                }
            }
            else
            {
                Console.WriteLine($"У {name} недостаточно полномочий для того, чтобы давать кому-то нагоняй");
            }
        }

        public void GiveABonus(object o)
        {
            if (rang >= 4)
            {
                Employee emp = o as Employee;
                if (emp != null)
                {
                    Console.WriteLine($"{name} выписал'а премию {emp.Name}");
                }
                else
                {
                    Console.WriteLine("Такого сотрудника  нет");
                }
            }
            else
            {
                Console.WriteLine($"У {name}  недостаточно полномочий для того, чтобы выписывать кому-то премию");
            }
        }
    }
}
