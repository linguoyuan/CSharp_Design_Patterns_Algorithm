
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class BJOrderPizza : OrderPizza 
{
    public BJOrderPizza(string mType) : base(mType)
    {
        Console.WriteLine("---北京工厂的披萨");
        CreatePizza(mType);
    }

    public override Pizza CreatePizza(string pizzaType)
    {
        Pizza pizza = null;
        if (pizzaType.Equals("cheese"))
        {
            pizza = new CheesePizza();
        }
        else if (pizzaType.Equals("greek"))
        {
            pizza = new HotDogPizza();
        }
        else if (pizzaType.Equals("pepper"))
        {
            pizza = new PepperPizza();
        }
        
        if (pizza != null)
        {
            pizza.Bake();
            pizza.Box();
            pizza.Cut();
            pizza.Prepare();
        }
        return pizza;
    }
}