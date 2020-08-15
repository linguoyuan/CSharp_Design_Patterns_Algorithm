using System;

namespace _03抽象工厂
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory factory = new Factory("BeiJing", "cheese");
            Console.WriteLine("Hello World!");
        }
    }
}
