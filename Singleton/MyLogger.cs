using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Singleton
{
    /// <summary>
    /// Singleton pattern implementation for a logger class. This class ensures that only one instance of the logger exists throughout the application, providing a global point of access to the logging functionality.
    /// </summary>
    internal sealed class MyLogger
    {
        private static  MyLogger _logger;

        public string Directory { get; set; }

        //空构造器已经私有，外部无法实例化该类，其他类也无法继承该类
        private MyLogger()
        {
        }
        public static MyLogger GetInstance()
        {
            if (_logger == null)
            {
                _logger = new MyLogger();
            }
            return _logger;
        }

        public void Log(string message)
        {
            Console.WriteLine($"{Directory??"Default Directory"}：[{DateTime.Now}] {message}");
        }

    }
}
