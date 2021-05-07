using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Loans.Tests
{
    public class LoanPaymentCalculatorTestData
    {
        public static IEnumerable<TestCaseData> TestCases
        {
            get
            {
                yield return new TestCaseData(1000, 0.05, 1.0, 1600);
                yield return new TestCaseData(1000, 0.1, 1.0, 2200);
            }
        }

    }
}
