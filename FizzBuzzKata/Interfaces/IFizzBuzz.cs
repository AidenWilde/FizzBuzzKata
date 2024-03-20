namespace FizzBuzzKata.Interfaces
{
    public interface IFizzBuzz
    {
        public IFizzBuzzNumber GetFizzBuzzType(int number);

        public IEnumerable<IFizzBuzzNumber> Execute(IEnumerable<int> numbers);
    }
}