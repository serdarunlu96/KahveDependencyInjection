using Interfaces;

namespace KahveDependencyInjection.Services
{
    public class Mocca : ICoffee
    {
        private int _number;
        public Mocca()
        {
             _number = new Random().Next(1001);
        }

        public int GetNumber()
        {
            return _number;
        }
    }
}