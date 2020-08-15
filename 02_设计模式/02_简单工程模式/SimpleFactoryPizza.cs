
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class SimpleFactoryPizza {

    public SimpleFactoryPizza() {
    }


    /// <summary>
    /// @param pizzaType 
    /// @return
    /// </summary>
    public Pizza CreatePizza(String pizzaType)
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
        return null;
    }

}