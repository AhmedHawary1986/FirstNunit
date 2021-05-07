using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loans.Tests
{
    [TestFixture]
    public class LoanProductShould
    {
        private List<LoanProduct> loanProducts;

        [SetUp]

        public void Setup()
        {
            loanProducts = new List<LoanProduct>
            {
                new LoanProduct(1,"a"),
                new LoanProduct(2,"b")
            };
        }

        [Test]
        [Category("Secondary One")]
        public void RespectCountList()
        {
            // Arrange
           

            Assert.That(loanProducts, Has.Exactly(2).Items);
        }

        [Test]
        [Category("Secondary Two")]
        public void RespectUnique()
        {
            Assert.That(loanProducts, Is.Unique);
        }
        [Test]
        public void RespectContains()
        {
            LoanProduct b = new LoanProduct(1, "a");

            Assert.That(loanProducts, Does.Contain(b));
        }

        [Test]
        public void RespectSpecificProduct()
        {
            Assert.That(loanProducts, Has.Exactly(1).Matches<LoanProduct>(x => x.Id == 1 && x.Name == "a"));
        }

        [Test]
        [Ignore("Ignored for example")]
        public void RespectIgnore()
        {
            Assert.That(loanProducts, Has.Exactly(1).With.Property("Id").EqualTo(2));
        }

        [TearDown]

        public void Tear()
        {
            loanProducts.Clear();
        }
    }
}
