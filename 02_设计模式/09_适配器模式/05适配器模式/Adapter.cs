using System;
using System.Collections.Generic;
using System.Text;

namespace _05适配器模式
{
    class Adapter
    {
        public int Convert(int homeVolt)
        {
            int chargeVolt = homeVolt - 215;
            return chargeVolt;
        }
    }
}
