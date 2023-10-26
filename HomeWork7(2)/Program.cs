using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7_2_
{
    internal class Program
    {

        static void Main(string[] args)
        {
            GeneralDirector general_director = new GeneralDirector("Семен");
            Console.Write("1) "); general_director.GetInfo();
            FinantialDirector finantial_director = new FinantialDirector("Рашид");
            Console.Write("2) ");  finantial_director.GetInfo();
            AutomatisationDirector automatisation_director = new AutomatisationDirector("О Ильхам");
            Console.Write("3) "); automatisation_director.GetInfo();
            HeadAccounting head_accounting = new HeadAccounting("Лукас");
            Console.Write("4) "); head_accounting.GetInfo();
            HeadIT head_it = new HeadIT("Оркадий");
            Console.Write("5) "); head_it.GetInfo();
            ViceIT vice_it = new ViceIT("Володя");
            Console.Write("6) "); vice_it.GetInfo();
            HeadSystemEngineers head_system_sngineers = new HeadSystemEngineers("Ильшат");
            Console.Write("7) "); head_system_sngineers.GetInfo();
            HeadDevelopers head_developres = new HeadDevelopers("Сергей");
            Console.Write("8) "); head_developres.GetInfo();
            ViceSystemEngineers vice_system_engineers = new ViceSystemEngineers("Иваныч");
            Console.Write("9) "); vice_system_engineers.GetInfo();
            ViceDevelopers vice_developres = new ViceDevelopers("Ляйсан");
            Console.Write("10) "); vice_developres.GetInfo();
            SystemEngineers system_engineer1 = new SystemEngineers("Илья");
            Console.Write("11) "); system_engineer1.GetInfo();
            SystemEngineers system_engineer2 = new SystemEngineers("Витя");
            Console.Write("12) "); system_engineer2.GetInfo();
            SystemEngineers system_engineer3 = new SystemEngineers("Женя");
            Console.Write("13) "); system_engineer3.GetInfo();
            Developers developer1 = new Developers("Марат");
            Console.Write("14) "); developer1.GetInfo();
            Developers developer2 = new Developers("Дина");
            Console.Write("15) "); developer2.GetInfo();
            Developers developer3 = new Developers("Ильдар");
            Console.Write("16) "); developer3.GetInfo();
            Developers developer4 = new Developers("Антон");
            Console.Write("17) "); developer4.GetInfo();

            general_director.Kikc(developer4);
            general_director.GiveABonus(developer2);
            general_director.GiveScolding(finantial_director);

            finantial_director.Kikc(system_engineer3);
            finantial_director.SignPapers();

            head_accounting.GiveSalary();
            head_accounting.GiveSalary(system_engineer3);

            vice_it.GiveScolding(developer1);
            vice_it.GiveScolding(system_engineer2);
            vice_it.GiveABonus(developer2);

            developer1.Kikc(developer2);
            developer2.Programming();
            developer3.GiveABonus(developer4);

            system_engineer1.CheckTechnical();

            /*
            ArrayList employes = new ArrayList();
            employes.Add(new GeneralDirector("Семен"));
            employes.Add(new FinantialDirector("Рашид"));
            employes.Add(new AutomatisationDirector("О Ильхам"));
            employes.Add(new HeadAccounting("Лукас"));
            employes.Add(new HeadIT("Оркадий"));
            employes.Add(new ViceIT("Володя"));
            employes.Add(new HeadSystemEngineers("Ильшат"));
            employes.Add(new HeadDevelopers("Сергей"));
            employes.Add(new ViceSystemEngineers("Иваныч"));
            employes.Add(new ViceDevelopers("Ляйсан"));
            employes.Add(new SystemEngineers("Илья"));
            employes.Add(new SystemEngineers("Витя"));
            employes.Add(new SystemEngineers("Женя"));
            employes.Add(new Developers("Марат"));
            employes.Add(new Developers("Дина"));
            employes.Add(new Developers("Ильдар"));
            employes.Add(new Developers("Антон"));
            */
        }
    }
}
