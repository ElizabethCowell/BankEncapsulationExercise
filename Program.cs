using System;

namespace BankEncapsulationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var newBankAccount = new BankAccount();
            newBankAccount.Deposit();
            newBankAccount.GetBalance();
            
        }
    }
}
