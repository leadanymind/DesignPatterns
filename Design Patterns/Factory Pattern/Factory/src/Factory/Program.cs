using static System.Console;
using System;

namespace Factory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //create initial factory
            var factory = new SavingsAccountFactory() as ICreditUnionFactory;

            //factory creates us our citi account
            var citiAcct = factory.GetSavingsAccount("CITI-123");

            //factory creates our national account
            var nationalAcct = factory.GetSavingsAccount("NATIONAL-987");
            

            //output
            WriteLine($"My citi balance is ${citiAcct.Balance} and my national balance is ${nationalAcct.Balance}");

        }
    }
}
