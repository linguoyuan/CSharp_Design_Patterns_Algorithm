// 单例模式基类，继承它的子类为单例类
using UnityEngine;
namespace UDMAF
{
    public class Singleton<T>: MonoBehaviour where T: Singleton<T>
    {
        private static T _Instance;

        public static T Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = FindObjectOfType<T>();
                }
                return _Instance;
            }
        }
    }

    
}