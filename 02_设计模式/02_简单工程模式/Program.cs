
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{

    public Program() {
    }

    static void Main()
    {
        SimpleFactoryPizza myPizza = new SimpleFactoryPizza();
        myPizza.CreatePizza("cheese");
        Console.ReadLine();
    }
}