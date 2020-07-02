using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UDMAF
{
    public class SingletonClass1 : Singleton<SingletonClass1>
    {
        public void Test()
        {
            Debug.Log("111111");
        }
    }
}
