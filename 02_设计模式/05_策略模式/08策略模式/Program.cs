using System;

namespace _08策略模式
{
    class Program
    {
        static void Main(string[] args)
        {
            StrategyContext context = new StrategyContext();
            context.stragegy = new ConcreteStrategyB();

            context.Cal();
        }
    }
    public class StrategyContext
    {
        public IStrategy stragegy;
        public void Cal()
        {
            stragegy.Cal();
        }
    }

    public interface IStrategy
    {
        void Cal();
    }
    public class ConcreteStrategyA : IStrategy
    {

        public void Cal()
        {
            Console.WriteLine("使用A策略计算"); 
        }
    }
    public class ConcreteStrategyB : IStrategy
    {

        public void Cal()
        {
            Console.WriteLine("使用B策略计算");
        }
    }
}
