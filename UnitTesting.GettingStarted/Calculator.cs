using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.GettingStarted
{
    public class Calculator
    {
        private readonly CreditDecison _creditDecison = new CreditDecison();

        public CreditDecison CreditDecison
        {
            get { return _creditDecison; }
        }

        public int Add(int lhs, int rhs)
        {
            return lhs + rhs;
        }
    }
}
