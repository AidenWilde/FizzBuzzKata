using FizzBuzzKata.Interfaces;

namespace FizzBuzzKata
{
    public class NormalNumber : IFizzBuzzNumber
    {
        private int _value;

        public int GetValue()
        {
            return _value;
        }
    }
}
