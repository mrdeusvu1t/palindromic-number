﻿using NUnit.Framework;
using System;
using static PalindromicNumberTask.NumbersExtension;

namespace PalindromicNumberTask.Tests
{
    public class NumbersExtensionTests
    {
        [TestCase(0, ExpectedResult = true)]
        [TestCase(1, ExpectedResult = true)]
        [TestCase(123321, ExpectedResult = true)]
        [TestCase(1233321, ExpectedResult = true)]
        [TestCase(1111111, ExpectedResult = true)]
        [TestCase(123321, ExpectedResult = true)]
        [TestCase(1233321, ExpectedResult = true)]
        [TestCase(1111111, ExpectedResult = true)]
        [TestCase(987656789, ExpectedResult = true)]
        public bool IsPalindromicNumber_Returns_True(int number) => IsPalindromicNumber(number);
        
        [TestCase(int.MaxValue, ExpectedResult = false)]
        [TestCase(12345, ExpectedResult = false)]
        [TestCase(987654, ExpectedResult = false)]
        [TestCase(2778, ExpectedResult = false)]
        [TestCase(1111111112, ExpectedResult = false)]
        [TestCase(1234654321, ExpectedResult = false)]
        public bool IsPalindromicNumber_Returns_False(int number) => IsPalindromicNumber(number);

        [Test]
        public void IsPalindromicNumber_ThrowArgumentException_If_Number_Is_Less_Than_Zero() =>
            Assert.Throws<ArgumentException>(() => IsPalindromicNumber(-1234654321),
                message: "number can not be less or equal zero");

        [Test]
        [Order(2)]
        [Timeout(500)]
        public void IsPalindromicNumber_Possibly_Very_Slow_Works_With_Time_Less_Than_1000_Milliseconds()
        {
            for (int source = 0; source < 1_000_000; source++)
            {
                IsPalindromicNumber(source);
            }
        }

        [Test]
        [Order(1)]
        [Timeout(2_000)]
        public void IsPalindromicNumber_Possibly_Very_Slow_Works_With_Time_Less_Than_25000_Milliseconds()
        {
            for (int source = 0; source < 10_000_000; source++)
            {
                IsPalindromicNumber(source);
            }
        }
    }
}