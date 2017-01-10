using System;

namespace AbstractFactory
{
    public class NationalLoanAccount :ILoanAccount
    {
        public NationalLoanAccount()
        {
            Console.WriteLine("Returned National Loan Account");
        }
    }
}
