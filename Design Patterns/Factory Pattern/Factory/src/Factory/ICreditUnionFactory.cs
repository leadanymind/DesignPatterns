namespace Factory
{
    //Creator
    interface ICreditUnionFactory
    {
        ISavingsAccount GetSavingsAccount(string AcctNum);
    }

}
