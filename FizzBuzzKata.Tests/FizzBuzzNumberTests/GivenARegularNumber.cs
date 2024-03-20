using FizzBuzzKata.Interfaces;
using NUnit.Framework;

namespace FizzBuzzKata.Tests.FizzBuzzTests
{
    [TestFixture]
    public class GivenARegularNumber
    {
        private IFizzBuzz _subject;
        private IFizzBuzzNumber _result = default!;

        [SetUp]
        public void WhenTheNumberIsNotModulaByThreeOrFive()
        {
            _subject = new FizzBuzzKata();

            _result = _subject.GetFizzBuzzType(2);
        }

        [Test]
        public void ThenTheTypeIsNormal()
        {
            Assert.That(_result.GetType(), Is.EqualTo(typeof(NormalNumber)));
        }

        [Test]
        public void ThenTheNumberIsTheSameAsInitialized()
        {
            Assert.That(2, Is.EqualTo(_result.GetValue()));
        }
    }
}
