using System;

namespace 工厂模式
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderPizza mOrderPizza;
            //广州披萨工厂生产的披萨
            mOrderPizza = new GZOrderPizza("cheese");

        }
    }
}
