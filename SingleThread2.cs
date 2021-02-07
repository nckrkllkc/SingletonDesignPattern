using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public class SingleThread2
    {
        private static SingleThread2 instance;
        private SingleThread2()
        {
             
        }

        public static SingleThread2 GetInstance()
        {
            if (instance == null)
            {
                instance = new SingleThread2();
            }
            return instance;
        }
    }
}
