using FizzBuzzKata;
using FizzBuzzKata.Interfaces;

namespace FizzBuzzKata
{
    public class Buzz : IFizzBuzzNumber
    {
        private int _value;

        public int GetValue()
        {
            return _value;
        }
    }
}

