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
            _subject = new FizzBuzz();
        }

        [Test]
        public void ThenTheTypeIsNormal()
        {
            _result = _subject.GetFizzBuzzType(2);
            Assert.Equals(_result.GetType(), typeof(NormalNumber));
        }
    }
}
