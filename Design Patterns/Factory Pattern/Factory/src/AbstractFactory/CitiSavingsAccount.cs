using System;

namespace AbstractFactory
{
    //Concreate Product
    public class CitiSavingsAccount : ISavingsAccount
    {
        public CitiSavingsAccount()
        {
            Console.WriteLine("Returned Citi Savings account");
        }
    }
}
