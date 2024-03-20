using FizzBuzzKata.Interfaces;
using NUnit.Framework;

namespace FizzBuzzKata.Tests.FizzBuzzTests
{
    [TestFixture]
    public class GivenAFizzBuzzNumber
    {
        private IFizzBuzz _subject;
        private IFizzBuzzNumber _result = default!;

        [SetUp]
        public void WhenTheNumberIsModulaByThreeAndFive()
        {
            _subject = new FizzBuzzKata();

            _result = _subject.GetFizzBuzzType(5);
        }

        [Test]
        public void ThenTheTypeIsFizzBuzz()
        {
            Assert.Equals(_result.GetType(), typeof(Buzz));
        }

        [Test]
        public void ThenTheNumberIsTheSameAsInitialized()
        {
            Assert.Equals(5, _result.GetValue());
        }
    }
}
