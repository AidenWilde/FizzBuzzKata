using FizzBuzzKata.Interfaces;
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
            _subject = new FizzBuzz();
        }

        [Test]
        public void ThenTheTypeIsBuzz()
        {
            _result = _subject.GetFizzBuzzType(5);
            Assert.Equals(_result.GetType(), typeof(Buzz));
        }

        [Test]
        public void ThenTheNumberIsTheSameAsInitialized()
        {
            Assert.Equals(5, _result.Value);
        }
    }
}
