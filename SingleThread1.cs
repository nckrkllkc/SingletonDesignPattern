using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public class SingleThread1
    {
        //
        private static SingleThread1 instanceForSingleThread = new SingleThread1();
        //
        private SingleThread1()
        {

        }

        public static SingleThread1 instance
        {
            get
            {
                return instanceForSingleThread;
            }
        }
    }
}
