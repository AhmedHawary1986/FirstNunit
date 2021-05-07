using System;
using System.Collections.Generic;
using System.Text;
using Loans;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace Loans.Tests
{
    [TestFixture]
    [Category("Loan Term")]
    class LoanTermShould
    {
        LoanTerm loan;
        [OneTimeSetUp]
        public void OnTimeSetup()
        {
            // Arrange
            loan = new Loans.LoanTerm(1);
        }
        [Test]
        [Category("Secondary One")]
        public void ShouldGreaterThanZero()
        {
            Assert.That(() => new LoanTerm(0), Throws.TypeOf<ArgumentOutOfRangeException>());
        }
        [Test]
        [Category("Secondary Two")]
        [Category("Secondary Three")]
        public void ReturnTermInMonth()
        {




            //Act 

            var res = loan.ReturnTermInMonth();

            // Assert

            Assert.That(res, Is.EqualTo(12), "The month is year * 12");
        }

        [Test]

        public void GetYesrs()
        {



            Assert.That(loan.Years, Is.EqualTo(1));
        }

        [Test]
        public void RespectValueEquality()
        {
            // Arrange


            var b = new LoanTerm(1);

            // Assert

            Assert.That(loan.Years, new EqualConstraint(b.Years));
        }

        [Test]
        public void RespectValueInEquality()
        {


            var b = new LoanTerm(2);

            Assert.That(loan, Is.Not.EqualTo(b));
        }

        [Test]
        public void RespectReferenceEquality()
        {

            var b = loan;

            Assert.That(loan, Is.SameAs(b));
        }

        [Test]

        public void RespectReferenceInEquality()
        {

            var b = new LoanTerm(1);

            Assert.That(loan, Is.Not.EqualTo(b));
        }

        [Test]

        public void RespectDouble()
        {
            //Arrange



            var b = loan.ReturnOneThird();

            Assert.That(b, Is.EqualTo(0.33).Within(10).Percent);
        }

        [Test]
        public void RespectExeptionMessage()
        {
            Assert.That(() => new LoanTerm(0), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.EqualTo("Years value must be greater than zero (Parameter 'Years')"));

        }

        [Test]
        public void RespectExeptionParameter()
        {
            Assert.That(() => new LoanTerm(0), Throws.TypeOf<ArgumentOutOfRangeException>().With.Matches<ArgumentOutOfRangeException>(x => x.ParamName == "Years"));
        }

        [OneTimeTearDown]
        public void OnTimeTearDown()
        {
            loan.Dispose();
        }
    }
}
