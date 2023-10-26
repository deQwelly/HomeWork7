using System;
using System.Collections.Generic;

namespace HomeWork6_1_
{
    public enum BankAccountType { current, saving }
    class BankAccount
    {
        private ulong number;
        private double balance;
        private BankAccountType type;
        static List<ulong> numbers = new List<ulong>();
        
        public BankAccount(BankAccountType type)
        {
            Random rnd = new Random();
            ulong temp = ulong.Parse(rnd.Next(1000, 10000).ToString() + rnd.Next(1000, 10000).ToString() +
                rnd.Next(1000, 10000).ToString() + rnd.Next(1000, 10000).ToString());
            if (numbers.Contains(temp)) 
            {
                while (numbers.Contains(temp))
                {
                    temp = ulong.Parse(rnd.Next(1000, 10000).ToString() + rnd.Next(1000, 10000).ToString() +
                rnd.Next(1000, 10000).ToString() + rnd.Next(1000, 10000).ToString());
                }
                numbers.Add(temp);
                number = temp;
            }
            else
            {
                numbers.Add(temp);
                number = temp;
            }
            this.type = type;
            this.balance = 0;
        }

        public ulong Number
        {
            get
            {
                return number;
            }
        }

        public double Balance
        {
            get
            {
                return balance;
            }
        }

        public BankAccountType Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

        /// <summary>
        /// Повзволяет снять деньги со счета
        /// </summary>
        /// <param name="sum"></param>
        public void TakeSomeMoney(double sum)
        {
            try
            {
                checked
                {
                    sum = Math.Round(sum, 2);
                    double temp = balance - sum;
                    if (temp > 0)
                    {
                        balance = temp;
                    }
                    else
                    {
                        Console.WriteLine("Недостаточно средств");
                    }
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Нельзя списать такую большую сумму");
            }
        }

        /// <summary>
        /// Вносит деньги на счет
        /// </summary>
        /// <param name="sum"></param>
        public void DepositSomeMoney(double sum)
        {
            try
            {
                checked
                {
                    sum = Math.Round(sum, 2);
                    balance += sum;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Нельзя внести такую большую сумму");
            }
        }

        /// <summary>
        /// Переводит на счет указанную сумму из указанного счета
        /// </summary>
        /// <param name="transfer_account"></param>
        /// <param name="sum"></param>
        public void TransferToThisAccount(BankAccount transfer_account, double sum)
        {
            try
            {
                checked
                {
                    if (transfer_account.balance >= sum)
                    {
                        transfer_account.balance -= sum;
                        balance += sum;
                    }
                    else
                    {
                        Console.WriteLine("На счете недостаточно средств");
                    }
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Нельзя перевести такую большую сумму");
            }
        }
    }
}
