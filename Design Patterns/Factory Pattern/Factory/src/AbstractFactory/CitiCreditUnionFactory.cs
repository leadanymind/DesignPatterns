namespace AbstractFactory
{
    public class CitiCreditUnionFactory : ICreditUnionFactory
    {
        public override ILoanAccount CreateLoanAccount()
        {
            return new CitiLoanAccount();
        }

        public override ISavingsAccount CreateSavingsAccount()
        {
            return new CitiSavingsAccount();
        }
    }
}
