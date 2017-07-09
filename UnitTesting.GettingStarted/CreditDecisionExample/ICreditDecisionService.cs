using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.GettingStarted.CreditDecisionExample
{
    public interface ICreditDecisionService
    {
        string GetDecision(int creditScore);
    }
}
