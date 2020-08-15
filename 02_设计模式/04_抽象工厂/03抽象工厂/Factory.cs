using System;
using System.Collections.Generic;
using System.Text;

class Factory : IFactory
{
    public Factory (string loactionType, string orderType)
    {
        CreateFactory(loactionType, orderType);
    }
    public void CreateFactory(string loactionType, string orderType)
    {
        Pizza pizza = null;
        switch (loactionType)
        {
            case "BeiJing":
                BJOrderPizza bj = new BJOrderPizza(orderType);
                break;
            case "GuangZhou":
                GZOrderPizza gz = new GZOrderPizza(orderType);
                break;
            default:
                break;
        }
    }
}

