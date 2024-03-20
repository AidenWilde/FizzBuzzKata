using FizzBuzzKata.Interfaces;
using NUnit.Framework;

namespace FizzBuzzKata.Tests.FizzBuzzTests
{
    [TestFixture]
    public class GivenAFizzNumber
    {
        private IFizzBuzz _subject;
        private IFizzBuzzNumber _result = default!;

        [SetUp]
        public void WhenTheNumberIsModulaByThree()
        {
            _subject = new FizzBuzzKata();

            _result = _subject.GetFizzBuzzType(3);
        }

        [Test]
        public void ThenTheTypeIsFizz()
        {
            Assert.That(_result.GetType(), Is.EqualTo(typeof(FizzNumber)));
        }

        [Test]
        public void ThenTheNumberIsTheSameAsInitialized()
        {
            Assert.That(3, Is.EqualTo(_result.GetValue()));
        }
    }
}
