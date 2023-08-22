using Interfaces;

namespace KahveDependencyInjection.Services
{
    public class Latte : ICoffee
    {
        private int _number;
        public Latte() 
        {
             _number = new Random().Next(1001); 
        }

        public int GetNumber()
        {
            return _number;
        }
    }
}
