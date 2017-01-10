using System;
using System.Collections.Generic;

namespace AbstractFactory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> AccountNumbers = new List<string>
                                        {
                                            "CITI-123",
                                            "NATIONAL - 456",
                                            "CHASE-789"
                                        };

            for (int i = 0; i < AccountNumbers.Count; i++)
            {
                ICreditUnionFactory anAbstractFactory = CreditUnionFactoryProvider.GetCreditUnionFactory(AccountNumbers[i]);

                if (anAbstractFactory == null)
                {
                    Console.WriteLine($"Sorry, This credit union w/ account number {AccountNumbers[i]} is invalid.");
                }
                else
                {
                    ILoanAccount loan = anAbstractFactory.CreateLoanAccount();
                    ISavingsAccount savings = anAbstractFactory.CreateSavingsAccount();
                }
            }


            Console.ReadLine();
        }
    }
}
