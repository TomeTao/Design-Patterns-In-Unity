using UnityEngine;

//����ģʽ
namespace DesignPattern.Example.SingletonPattern
{
    public class Singleton : MonoBehaviour
    {
        private static Singleton _instance;

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }

        private Singleton()
        {
            // ���캯��
        }

    }
}


