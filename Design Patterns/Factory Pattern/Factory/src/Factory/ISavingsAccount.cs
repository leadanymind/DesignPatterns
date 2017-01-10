using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Factory
{
    //Product
    public abstract class ISavingsAccount
    {
        public decimal Balance { get; set; }
    }
}
