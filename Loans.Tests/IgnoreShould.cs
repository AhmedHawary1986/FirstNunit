using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loans.Tests
{
    [TestFixture]
    [Ignore("Ignore All Class")]
    public class IgnoreShould
    {
        [Test]
        public void IgnoreUpperCase()
        {
            string name = "AHMED";

            Assert.That(name, Is.EqualTo("Ahmed").IgnoreCase);
        }
    }
}
