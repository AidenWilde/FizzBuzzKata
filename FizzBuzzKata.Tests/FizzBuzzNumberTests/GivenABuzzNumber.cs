﻿using FizzBuzzKata.Interfaces;
using NUnit.Framework;

namespace FizzBuzzKata.Tests.FizzBuzzTests
{
    [TestFixture]
    public class GivenABuzzNumber
    {
        private IFizzBuzz _subject;
        private IFizzBuzzNumber _result = default!;

        [SetUp]
        public void WhenTheNumberIsModulaByFive()
        {
            _subject = new FizzBuzzKata();

            _result = _subject.GetFizzBuzzType(5);
        }

        [Test]
        public void ThenTheTypeIsBuzz()
        {
            Assert.That(_result.GetType(), Is.EqualTo(typeof(BuzzNumber)));
        }

        [Test]
        public void ThenTheNumberIsTheSameAsInitialized()
        {
            Assert.That(5, Is.EqualTo(_result.GetValue()));
        }
    }
}
