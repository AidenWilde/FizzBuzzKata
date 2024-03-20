using FizzBuzzKata.Interfaces;
using Moq;
using NUnit.Framework;

namespace FizzBuzzKata.Tests
{
    [TestFixture]
    public class GivenAFizzBuzzKata
    {
        Mock<IFizzBuzz> _subject;

        [SetUp]
        public void WhenItRunsWithOneHundredNumbers()
        {
            var numbers = Enumerable.Range(0, 15).ToList();
            
            _subject = new Mock<IFizzBuzz>();

            _subject.Setup(_ => _.Execute(It.IsAny<IEnumerable<int>>())).Returns(
                new List<IFizzBuzzNumber>() { }
                );

        }
    }
}
