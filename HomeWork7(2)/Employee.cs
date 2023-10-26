using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7_2_
{
    public enum Departments
    {
        IT, Financial, HeadCompany
    }
    abstract class Employee
    {
        protected string name;
        protected byte rang;
        protected Departments department;

        public string Name
        {
            get
            {
                return name;
            }
        }

        public Departments Department
        {
            get
            {
                return department;
            }
        }

        public void GetInfo()
        {
            Console.WriteLine($"{name}\t|\tранг {rang}\t|\t{department}");
        }
    }
}
