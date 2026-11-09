using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace Singleton
{
    internal sealed class ConnectionPool
    {
        private readonly int _maxSize;
        private readonly Queue<DbConnection> _availabel;
        private readonly Queue<DbConnection> _inUse;

        private static Lazy<ConnectionPool> _instance;
        private static ConnectionPool Instance => _instance.Value;


        private ConnectionPool(int maxSize)
        {
            _maxSize = maxSize;
        }
    }
}
