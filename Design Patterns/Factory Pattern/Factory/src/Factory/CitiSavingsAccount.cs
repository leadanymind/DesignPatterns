using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Factory
{
    //Concrete Product
    public class CitiSavingsAccount : ISavingsAccount
    {
        
            public CitiSavingsAccount()
            {
                Balance = 5000;
            }
        
    }
}
