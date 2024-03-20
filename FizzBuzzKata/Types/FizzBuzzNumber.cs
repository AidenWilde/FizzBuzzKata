using FizzBuzzKata.Interfaces;

namespace FizzBuzzKata
{
    public class FizzBuzz : IFizzBuzzNumber
    {
        private int _value;

        public FizzBuzz(int value)
        {
            _value = value;
        }

        public int GetValue()
        {
            return _value;
        }
    }
}
