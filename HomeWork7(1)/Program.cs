using HomeWork6_1_;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7_1_
{
    internal class Program
    {
        public static Random rnd = new Random();

        /// <summary>
        /// Возвращает указанную строку в обратном порядке
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ReverseThisString(string str)
        {
            return string.Join("", str.Reverse());
        }

        /// <summary>
        /// реализует ли входной параметр метода интерфейс System.IFormattable.
        /// </summary>
        /// <param name="o"></param>
        public static bool DoesItImplementIFormattable(object o)
        {
            IFormattable temp = o as IFormattable;
            if (temp != null)
            {
                return true;
            }
            else
            {
                return false;
            }

            /*
            if (o is IFormattable)
            {
                return true;
            }
            else
            {
                return false;
            }
            */
        }

        public static void FindeEmail(ref string str)
        {
            str = str.Substring(str.IndexOf("#") + 2);
        }

        static void Main(string[] args)
        {
            //Упражнение 8.1
            Console.WriteLine("Упражнение 8.1 В класс банковский счет, созданный в упражнениях 7.1- 7.3 добавить" +
                "\r\nметод, который переводит деньги с одного счета на другой. У метода два параметра: ссылка" +
                "\r\nна объект класса банковский счет откуда снимаются деньги, второй параметр – сумма.");
            BankAccount account1 = new BankAccount(BankAccountType.saving);
            BankAccount account2 = new BankAccount(BankAccountType.current);
            account1.DepositSomeMoney(1000.111);
            account2.DepositSomeMoney(2222.222);
            account1.TransferToThisAccount(account2, 222.22);
            Console.WriteLine(account1.Balance);
            Console.WriteLine(account2.Balance);

            //Упражнение 8.2
            Console.WriteLine("\nУпражнение 8.2 Реализовать метод, который в качестве входного параметра принимает" +
                "\r\nстроку string, возвращает строку типа string, буквы в которой идут в обратном порядке.\r\nПротестировать метод.");
            Console.Write("Введите любую строку: ");
            Console.WriteLine(ReverseThisString(Console.ReadLine()));

            //Упражнение 8.3
            Console.WriteLine("\nУпражнение 8.3 Написать программу, которая спрашивает у пользователя имя файла. " +
                "Если\r\nтакого файла не существует, то программа выдает пользователю сообщение и заканчивает" +
                "\r\nработу, иначе в выходной файл записывается содержимое исходного файла, но заглавными\r\nбуквами.");
            Console.Write("Введите имя файла (существует файл Task 8.3.txt): ");
            string path = Console.ReadLine();
            if (File.Exists(path))
            {
                string [] file_value = File.ReadAllLines(path);
                foreach (string line in file_value)
                {
                    File.AppendAllText("Task 8.3 (new).txt", line.ToUpper() + "\n");
                }
            }
            else
            {
                Console.WriteLine("Введенный файл не найден");
            }

            //Упражнение 8.4
            Console.WriteLine("\nУпражнение 8.4 Реализовать метод, который проверяет реализует ли входной параметр" +
                "\r\nметода интерфейс System.IFormattable. Использовать оператор is и as. (Интерфейс\r\nIFormattable" +
                " обеспечивает функциональные возможности форматирования значения объекта\r\nв строковое представление.)");
            string s = "";
            if (DoesItImplementIFormattable(s))
            {
                Console.WriteLine("Может");
            }
            else
            {
                Console.WriteLine("Не может");
            }

            //Домашнее задание 8.1
            Console.WriteLine("\nДомашнее задание 8.1 Дан текстовый файл, содержащий ФИО и e-mail адрес. " +
                "Сформировать новый файл, содержащий список адресов электронной почты.");
            if (!File.Exists("Home Task 8.1 (new).txt"))
            {
                string[] person_data = File.ReadAllLines("Home Task 8.1.txt");
                for (int i = 0; i < person_data.Length; i++)
                {
                    FindeEmail(ref person_data[i]);
                    ///Console.WriteLine(person_data[i]);
                    ///Console.WriteLine(person_data[i].Substring(person_data[i].IndexOf("#") + 2));
                }
                File.AppendAllLines("Home Task 8.1 (new).txt", person_data);
            }

            //Домашнее задание 8.2
            Console.WriteLine("\nСписок песен. В методе Main создать список из четырех песен.\n" +
                "В цикле вывести информацию о каждой песне. Сравнить между собой первую и вторую песню в списке.");
            List<Song> songs = new List<Song>();
            songs.Add(new Song("Feeling Good", "Michael Buble", null));
            songs.Add(new Song("Feeling Good", "Michael Buble", songs[0]));
            songs.Add(new Song("Неважно", "Конец солнечных дней", songs[1]));
            songs.Add(new Song("The Show Must Go On", "Qween", songs[2]));
            foreach (var song in songs)
            {
                Console.WriteLine(song.Title());
            }
            Console.WriteLine($"Первая и вторая песни в списке одинаковы? {songs[1].Equals(songs[1].Prev)}");
        }
    }
}
