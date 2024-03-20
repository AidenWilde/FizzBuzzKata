using FizzBuzzKata.Interfaces;

namespace FizzBuzzKata
{
    public class NormalNumber : IFizzBuzzNumber
    {
        private int _value;

        public NormalNumber(int value)
        {
            _value = value;
        }

        public int GetValue()
        {
            return _value;
        }
    }
}
