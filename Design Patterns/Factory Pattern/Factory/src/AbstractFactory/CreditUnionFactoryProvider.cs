namespace AbstractFactory
{
    public static class CreditUnionFactoryProvider
    {
        public static ICreditUnionFactory GetCreditUnionFactory(string AccountNum)
        {
            if (AccountNum.Contains("CITI"))
                { return new CitiCreditUnionFactory(); }
            else if (AccountNum.Contains("NATIONAL"))
                { return new NationalCreditUnionFactory(); }
            else
                return null;

        }
    }
}
