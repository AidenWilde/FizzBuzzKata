using FizzBuzzKata.Interfaces;

namespace FizzBuzzKata
{
    public class Fizz : IFizzBuzzNumber
    {
        private int _value;

        public int GetValue()
        {
            return _value;
        }
    }
}
