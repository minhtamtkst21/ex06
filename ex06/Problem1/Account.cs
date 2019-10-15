using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    public class Account
    {
        int acc = 0;
        public Account(int amount)
        {
            acc = amount;
        }
        public void Deposit(int amount)
        {
            Console.Write("so tien nap: ");
            acc = int.Parse(Console.ReadLine());
            amount += acc;
        }
        public void Withdraw(int amount)
        {
            Console.Write("so tien rut: ");
            acc = int.Parse(Console.ReadLine());
            amount -= acc;
        }
        public int Balance()
        {
            return acc;
        }
    }
}
