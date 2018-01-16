using System;
using Xunit;
using Moq;

namespace CreditCardApplications.Tests
{
    public class CreditCardApplicationEvaluatorShould
    {
        [Fact]
        public void AcceptHighIncomeApplications()
        {

            var sut = new CreditCardApplicationEvaluator();

            var application = new CreditCardApplication { GrossAnnualIncome = 100_000 };

            CreditCardApplicationDecision decision = sut.Evaluate(application);

            Assert.Equal(CreditCardApplicationDecision.AutoAccepted, decision);

        }

        [Fact]
        public void ReferYoungApplications()
        {

            var sut = new CreditCardApplicationEvaluator();

            var application = new CreditCardApplication { Age = 20 };

            CreditCardApplicationDecision decision = sut.Evaluate(application);

            Assert.Equal(CreditCardApplicationDecision.ReferredToHuman, decision);

        }

        //Other evaluator test conditions.

    }
}
