using System;

namespace _09模板模式
{
    class Program
    {
        static void Main(string[] args)
        {
            IPeople people = new NorthPeople();
            people.Eat();
        }
    }

    public abstract class IPeople
    {

        public void Eat()
        {
            OrderFoods();
            EatSomething();
            PayBill();
        }
        private void OrderFoods()
        {
            Console.WriteLine("点单");
        }

        protected virtual void EatSomething()
        {

        }

        private void PayBill()
        {
            Console.WriteLine("买单");
        }
    }

    public class NorthPeople : IPeople
    {
        protected override void EatSomething()
        {
            Console.WriteLine("我在吃面条");
        }
    }

    public class SouthPeople : IPeople
    {
        protected override void EatSomething()
        {
            Console.WriteLine("我在吃米饭");
        }
    }
}
