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
        }

        [Test]
        public void ThenTheTypeIsFizz()
        {
            _result = _subject.GetFizzBuzzType(3);
            Assert.Equals(_result.GetType(), typeof(Fizz));
        }
    }
}
