using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public class MultiThread
    {
        //volatile kullanımı yapıp oluşturulan instance'a data register yerine ana bellek üzerinden erişme sağlanabilir.
        private static MultiThread multiThreadInstance = null;
        private static readonly Object InstanceLock = new object();
        private MultiThread()
        {

        }
        public static MultiThread Instance 
        {
            get
            {
                //double checked locking approach
                if (multiThreadInstance == null)
                {
                    //instance sadece boş olduğunda kitleme işlemi olacaktır.
                    lock (InstanceLock)
                    {
                        if (multiThreadInstance == null)
                        {
                            multiThreadInstance = new MultiThread();
                        }
                    }
                }
                return multiThreadInstance;
            }
        }
    }
}
