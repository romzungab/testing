namespace UnitTesting.GettingStarted.CreditDecisionExample
{
    public class CreditDecison
    {
        private ICreditDecisionService creditDecisionService;

        public CreditDecison(ICreditDecisionService creditDecisionService)
        {
            this.creditDecisionService = creditDecisionService;
        }
        public string MakeCreditDecision(int creditScore)
        {
            return creditDecisionService.GetDecision(creditScore);
        }
    }
}