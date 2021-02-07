using System;

namespace SingletonDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleThread1 instance1 = SingleThread1.instance;
            SingleThread2 instance2 = SingleThread2.GetInstance();

            MultiThread instance = MultiThread.Instance;
        }
    }
}
