using System;

namespace _05适配器模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----使用适配器前-------");
            HomeBattery homeBattery = new HomeBattery();
            int homeVolt = homeBattery.Supply();
            USBLine uSBLine = new USBLine();
            uSBLine.Charge(homeVolt);

            Console.WriteLine("----使用适配器后-------");
            Adapter adapter = new Adapter();
            uSBLine.Charge(adapter.Convert(homeVolt));
        }
    }
}
