using FizzBuzzKata.Interfaces;

namespace FizzBuzzKata
{
    public class FizzNumber : IFizzBuzzNumber
    {
        private int _value;

        public FizzNumber(int value)
        {
            _value = value;
        }

        public int GetValue()
        {
            return _value;
        }
    }
}
