using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsC_.Singleton
{
    public class SingletonLogger
    {
        private static SingletonLogger _instance = null;
        private static readonly object _lock = new object();

        private SingletonLogger()
        { }

        public static SingletonLogger Instance()
        {
            if(_instance == null)
            {
                lock (_lock)
                {
                    if(_instance == null)
                    {
                        _instance = new SingletonLogger();
                    }
                }
            }

            return _instance;
        }

        public void Log(string message)
        {
            Console.WriteLine($"Log {message}");
        }
    }
}
