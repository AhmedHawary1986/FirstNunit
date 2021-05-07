using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using NUnit.Framework;
namespace Loans.Tests
{
    public class LoadPaymentTestDataWithCSV
    {
        public static IEnumerable<TestCaseData> GetTestCases(string CSVFileName)
        {
            var testCases = new List<TestCaseData>();

            var csvLines = File.ReadAllLines(CSVFileName);

            foreach(var csvLine in csvLines)
            {
                string[] lineList = csvLine.Replace(" ", "").Split(',');

                var OriginalCost = double.Parse(lineList[0]);

                var rate = double.Parse(lineList[1]);

                var loanTerm = double.Parse(lineList[2]);

                var expected = double.Parse(lineList[3]);

                testCases.Add(new TestCaseData(OriginalCost, rate, loanTerm).Returns(expected));
            }

            return testCases;
        }
    }
}
