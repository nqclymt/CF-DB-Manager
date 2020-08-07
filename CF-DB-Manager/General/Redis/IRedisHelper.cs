using MagicOnion;
using System;
using System.Collections.Generic;
using System.Text;
using StackExchange.Redis;
using System.Threading.Tasks;

namespace CF_DB_Manager
{
    public interface IRedisHelper
    {
        UnaryResult<bool> KeyExistsAsync(string key);
        UnaryResult<bool> KeyDeleteAsync(string key);
    }
}
