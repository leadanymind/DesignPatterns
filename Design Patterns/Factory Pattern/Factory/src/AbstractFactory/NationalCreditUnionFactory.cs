namespace AbstractFactory
{
    public class NationalCreditUnionFactory : ICreditUnionFactory
    {
        public override ILoanAccount CreateLoanAccount()
        {
            NationalLoanAccount loanAccount = new NationalLoanAccount();
            return loanAccount;
        }

        public override ISavingsAccount CreateSavingsAccount()
        {
            NationalSavingsAccount savingsAccount = new NationalSavingsAccount();
            return savingsAccount;
        }
    }
}
