
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class OrderPizza 
{

    public OrderPizza(string mType) 
    {

    }


    /// <summary>
    /// @return
    /// </summary>
    public abstract Pizza CreatePizza(string pizzaType);

}