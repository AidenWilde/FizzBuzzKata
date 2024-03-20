using FizzBuzzKata.Interfaces;

namespace FizzBuzzKata
{
    public class FizzBuzzKata : IFizzBuzz
    {
        public IEnumerable<IFizzBuzzNumber> Execute(IEnumerable<int> numbers)
        {
            var fizzBuzzNumbers = new List<IFizzBuzzNumber>();

            foreach(var number in numbers)
                fizzBuzzNumbers.Add(GetFizzBuzzType(number));

            return fizzBuzzNumbers;
        }

        public IFizzBuzzNumber GetFizzBuzzType(int number)
        {
            if (number % 5 == 0 && number % 3 == 0)
                return new FizzBuzzNumber(number);
            else if (number % 5 == 0)
                return new BuzzNumber(number);
            else if (number % 3 == 0)
                return new FizzNumber(number);
            else
                return new NormalNumber(number);
        }
    }
}
