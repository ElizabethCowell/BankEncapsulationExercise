using System;

namespace BankEncapsulationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var newBankAccount = new BankAccount();
            string selection;
            do
            {
                Console.WriteLine("What would you like to do today? \n" +
                                    "Deposit \n" +
                                    "Withdraw \n" +
                                    "Check balance \n" +
                                    "Exit");
                selection = Console.ReadLine().ToLower();
                switch (selection)
                {
                    case ("deposit"):
                        newBankAccount.Deposit();
                        break;
                    case ("withdraw"):
                        newBankAccount.Withdraw();
                        break;
                    case ("check balance"):
                        newBankAccount.GetBalance();
                        break;
                    case ("exit"):
                        break;
                    default:
                        Console.WriteLine("Please try again");
                        break;
                }
            } while (selection != "exit");
            
        }
    }
}
