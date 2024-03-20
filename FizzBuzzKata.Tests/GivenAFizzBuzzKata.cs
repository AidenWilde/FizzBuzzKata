using FizzBuzzKata.Interfaces;
using Moq;
using NUnit.Framework;

namespace FizzBuzzKata.Tests
{
    [TestFixture]
    public class GivenAFizzBuzzKata
    {
        FizzBuzzKata _subject;
        private IEnumerable<IFizzBuzzNumber> _result;

        [SetUp]
        public void WhenItRunsWithOneHundredNumbers()
        {
            _subject = new FizzBuzzKata();
            
            var numbers = Enumerable.Range(0, 100).ToList();
            _result = _subject.Execute(numbers);
        }

        [Test]
        public void ThenThereAreOneHundredNumbers()
        {

        }

        [Test]
        public void ThenThereAreACertainNumberOfFizzBuzzNumbers()
        {

        }

        [Test]
        public void ThenThereAreACertainNumberOfFizzNumbers()
        {

        }

        [Test]
        public void ThenThereAreACertainNumberOfBuzzNumbers()
        {

        }

        [Test]
        public void ThenThereAreACertainNumberOfRegularNumbers()
        {

        }
    }
}
