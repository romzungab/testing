using Moq;
using NUnit.Framework;
using UnitTesting.GettingStarted.CreditDecisionExample;

namespace UnitTesting.GettingStarted.Tests
{
    [TestFixture]
    public class CreditDecisionTests
    {
        private Mock<ICreditDecisionService> mockCreditDecisionService;

        private CreditDecison systemUnderTest;

        [TestCase(100, "Declined")]
        [TestCase(549, "Declined")]
        [TestCase(550, "Maybe")]
        [TestCase(674, "Maybe")]
        [TestCase(676, "We look forward for doing business with you!")]
        public void MakeCreditDecision_Always_ReturnsExpectedResult(int creditScore, string expectedResult)
        {
            mockCreditDecisionService = new Mock<ICreditDecisionService>(MockBehavior.Strict);
            mockCreditDecisionService.Setup(p => p.GetDecision(creditScore)).Returns(expectedResult);

            systemUnderTest = new CreditDecison(mockCreditDecisionService.Object);
            var result = systemUnderTest.MakeCreditDecision(creditScore);

            Assert.That(result, Is.EqualTo(expectedResult));

            mockCreditDecisionService.VerifyAll();
        }
    }
}
