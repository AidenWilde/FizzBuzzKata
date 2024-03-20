using FizzBuzzKata.Interfaces;
using NUnit.Framework;

namespace FizzBuzzKata.Tests.FizzBuzzTests
{
    [TestFixture]
    public class GivenAFizzNumber
    {
        private IFizzBuzz _subject;

        [SetUp]
        public void WhenTheNumberIsModulaByThree()
        {
            _subject = new FizzBuzz();
        }

        [Test]
        public void ThenTheWordFizzIsOutput()
        {
            var result = _subject.GetFizzBuzzType(3);
            Assert.Equals(result.GetType(), typeof(Fizz));
        }
    }
}
