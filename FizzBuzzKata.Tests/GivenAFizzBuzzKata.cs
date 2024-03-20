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
            
            var numbers = Enumerable.Range(1, 100).ToList();
            _result = _subject.Execute(numbers);
        }

        [Test]
        public void ThenThereAreOneHundredNumbers()
        {
            Assert.That(_result.Count, Is.EqualTo(100));
        }

        [Test]
        public void ThenThereAreACertainNumberOfFizzBuzzNumbers()
        {
            var fizzBuzzNumbers = _result.Where(_ => _.GetType() == typeof(FizzBuzzNumber));
            Assert.That(fizzBuzzNumbers.Count, Is.EqualTo(6));
        }

        [Test]
        public void ThenThereAreACertainNumberOfFizzNumbers()
        {
            var fizzNumbers = _result.Where(_ => _.GetType() == typeof(FizzNumber));
            Assert.That(fizzNumbers.Count, Is.EqualTo(27));
        }

        [Test]
        public void ThenThereAreACertainNumberOfBuzzNumbers()
        {
            var fizzBuzzNumbers = _result.Where(_ => _.GetType() == typeof(BuzzNumber));
            Assert.That(fizzBuzzNumbers.Count, Is.EqualTo(14));
        }

        [Test]
        public void ThenThereAreACertainNumberOfRegularNumbers()
        {
            var normalNumbers = _result.Where(_ => _.GetType() == typeof(NormalNumber));
            Assert.That(normalNumbers.Count, Is.EqualTo(53));
        }
    }
}
