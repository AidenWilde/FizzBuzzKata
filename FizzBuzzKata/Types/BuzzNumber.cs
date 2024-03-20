using FizzBuzzKata;
using FizzBuzzKata.Interfaces;

namespace FizzBuzzKata
{
    public class BuzzNumber : IFizzBuzzNumber
    {
        private int _value;

        public BuzzNumber(int value)
        {
            _value = value;
        }

        public int GetValue()
        {
            return _value;
        }
    }
}

