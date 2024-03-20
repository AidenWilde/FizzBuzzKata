namespace FizzBuzzKata.Interfaces
{
    public interface IFizzBuzz
    {
        public IFizzBuzzNumber GetFizzBuzzType(int number);
        public void Execute();
    }
}