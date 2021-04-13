using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulationExercise
{
    public class BankAccount
    {
        private double balance = 0;

        public double Deposit()
        {
            Console.WriteLine("How much are you depositing today?");
            var deposit = int.Parse(Console.ReadLine());
            return balance += deposit;
        }
        public void GetBalance()
        {
            Console.WriteLine(balance);
        }
    }
}
