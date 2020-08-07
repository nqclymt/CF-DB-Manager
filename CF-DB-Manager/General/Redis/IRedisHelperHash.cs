using MagicOnion;
using System;
using System.Collections.Generic;
using System.Text;
using StackExchange.Redis;

namespace CF_DB_Manager
{
    public interface IRedisHelperHash : IService<IRedisHelperHash>,IRedisHelper
    {
        UnaryResult<bool> HashExistAsync(string key, string dataKey);
        UnaryResult<bool> HashSetAsync<T>(string key, string dataKey, T t);
        UnaryResult<bool> HashDeleteAsync(string key, string dataKey);
        UnaryResult<long> HashDeleteAsync(string key, params string[] dataKeys);
        UnaryResult<T> HashGetAsync<T>(string key, string dataKey);
        UnaryResult<double> HashIncrementAsync(string key, string dataKey, double value);
        UnaryResult<double> HashDecrementAsync(string key, string dataKey, double value);
        UnaryResult<string[]> HashKeysAsync(string key);
        UnaryResult<Dictionary<string, T>> HashGetAllAsync<T>(string key);
    }
}
