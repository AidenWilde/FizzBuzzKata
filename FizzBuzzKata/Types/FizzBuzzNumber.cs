using FizzBuzzKata.Interfaces;

namespace FizzBuzzKata
{
    public class FizzBuzzNumber : IFizzBuzzNumber
    {
        private int _value;

        public FizzBuzzNumber(int value)
        {
            _value = value;
        }

        public int GetValue()
        {
            return _value;
        }
    }
}
