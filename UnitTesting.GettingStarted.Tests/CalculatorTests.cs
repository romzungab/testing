﻿using NUnit.Framework;

namespace UnitTesting.GettingStarted.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [TestCase(1,2)]
        [TestCase(2,3)]
        [TestCase(5,7)]
        [TestCase(1000,1)]
        public void Add_Alway_ReturnsExpectedResult(int lhs, int rhs)
        {
            var systemUnderTest = new Calculator();
            var expected = lhs + rhs;
            Assert.That(systemUnderTest.Add(lhs, rhs), Is.EqualTo(expected));
        }

       
    }

}
