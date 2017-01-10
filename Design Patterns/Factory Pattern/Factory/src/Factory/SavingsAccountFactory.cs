using System;

namespace Factory
{
    //Concrete Creator
    public class SavingsAccountFactory : ICreditUnionFactory
    {
        public ISavingsAccount GetSavingsAccount(string AcctNum)
        {
            if (AcctNum.Contains("CITI")) { return new CitiSavingsAccount(); }
            else if (AcctNum.Contains("NATIONAL")) { return new NationalSavingsAccount(); }
            else throw new ArgumentException("Invalid account number");
        }
    }
}
 