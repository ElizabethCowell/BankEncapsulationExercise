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
        private string password = "password";

        public bool Verification()
        {
            Console.WriteLine("What is your password?");
            var answer = Console.ReadLine();
            if (answer == password)
            {
                return true;
            }
            else
                Console.WriteLine("Incorrect Password");
                return false;
        }
        public void Deposit()
        {
            var verify = Verification();
            if (verify)
            {
                Console.WriteLine("How much are you depositing today?");
                var deposit = int.Parse(Console.ReadLine());
                balance += deposit;
            }
        }
        public void GetBalance()
        {
            var verify = Verification();
            if (verify)
            {
                Console.WriteLine(balance);
            }
        }
        public void Withdraw()
        {
            var verify = Verification();
            if (verify)
            {
                Console.WriteLine("How much would you like to withdraw?");
                var withdraw = int.Parse(Console.ReadLine());
                if (withdraw > balance)
                {
                    Console.WriteLine("Insuficiant funds");
                }
                else
                {
                    balance -= withdraw;
                }
            }
        }
    }
}
