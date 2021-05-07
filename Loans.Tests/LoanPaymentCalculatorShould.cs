using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loans.Tests
{
    [TestFixture]
    public class LoanPaymentCalculatorShould
    {
        [Test]
        [TestCase(1000, 0.05, 1.0, 1600)]
        [TestCase(1000, 0.1, 1.0, 2200)]
        public void CalculateLoan(double OriginalCost, double Rate, double LoanTerm, double expected)
        {
            var sut = new LoanTerm(LoanTerm);

            var output = new LoanPaymentCalculator(OriginalCost, Rate, sut);

            Assert.That(output.CalculateLoan(), Is.EqualTo(expected));
        }

        [Test]
        [TestCase(1000, 0.05, 1.0, ExpectedResult = 1600)]
        [TestCase(1000, 0.1, 1.0, ExpectedResult = 2200)]
        public double CalculateLoan_Simplified(double OriginalCost, double Rate, double LoanTerm)
        {
            var sut = new LoanTerm(LoanTerm);

            var output = new LoanPaymentCalculator(OriginalCost, Rate, sut);

            return output.CalculateLoan();
        }

        [Test]
        [TestCaseSource(typeof(LoanPaymentCalculatorTestData), "TestCases")]

        public void CalculateLoan_Centralized(double OriginalCost, double Rate, double LoanTerm, double expected)
        {
            var sut = new LoanTerm(LoanTerm);

            var output = new LoanPaymentCalculator(OriginalCost, Rate, sut);

            Assert.That(output.CalculateLoan(), Is.EqualTo(expected));
        }

        [Test]
        [TestCaseSource(typeof(LoadPaymentCalculatorTestDataWithReturn),"TestCases")]
        public double CalculateLoan_Simplified_Centralized(double OriginalCost, double Rate, double LoanTerm)
        {
            var sut = new LoanTerm(LoanTerm);

            var output = new LoanPaymentCalculator(OriginalCost, Rate, sut);
            return output.CalculateLoan();


        }

        [Test]
        [TestCaseSource(typeof(LoadPaymentTestDataWithCSV), "GetTestCases", new object[] { "Data.csv"})]
        public double CalculateLoan_Simplified_Centralized_CSV(double OriginalCost, double Rate, double LoanTerm)
        {
            var sut = new LoanTerm(LoanTerm);

            var output = new LoanPaymentCalculator(OriginalCost, Rate, sut);
            return output.CalculateLoan();


        }

        [Test]
        public void CalculateLoanData_Generated(
        [Values(1000,5000,10000)] double OriginalCost,
         [Values(0.05,0.1,0.15)] double Rate,
         [Values(1,2,3)] double LoanTerm
            )
         
        
             
        {
            var sut = new LoanTerm(LoanTerm);

            var output = new LoanPaymentCalculator(OriginalCost, Rate, sut);
         


        }

        [Test]
        [Sequential]
        public void CalculateLoanData_Generated_Squential(
   [Values(1000, 1000)] double OriginalCost,
    [Values(0.05, 0.1)] double Rate,
    [Values(1, 1)] double LoanTerm,
    [Values(1600,2200)] double expected
       )



        {
            var sut = new LoanTerm(LoanTerm);

            var output = new LoanPaymentCalculator(OriginalCost, Rate, sut).CalculateLoan();

            Assert.That(output, Is.EqualTo(expected));

        }
    }
}
