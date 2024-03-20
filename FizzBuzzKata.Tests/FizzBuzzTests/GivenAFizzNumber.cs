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
            _subject = new FizzBuzz();

            _result = _subject.GetFizzBuzzType(3);
        }

        [Test]
        public void ThenTheTypeIsFizz()
        {
            Assert.Equals(_result.GetType(), typeof(Fizz));
        }

        [Test]
        public void ThenTheNumberIsTheSameAsInitialized()
        {
            Assert.Equals(3, _result.Value);
        }
    }
}
