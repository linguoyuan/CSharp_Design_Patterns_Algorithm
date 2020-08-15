using System;
using System.Collections.Generic;
using System.Text;

namespace _05适配器模式
{
    class USBLine
    {
        public void Charge(int volt)
        {
            if(volt == 5)
            {
                Console.WriteLine("正常充电");
            }
            else
            {
                Console.WriteLine("不能充电，只能接收5V电压");
            }
        }
    }
}
