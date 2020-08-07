using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;
using MagicOnion;
using MagicOnion.Server;
namespace CF_DB_Manager
{
    public class RedisHelperString : ServiceBase<IRedisHelperString>, IRedisHelperString
    {
        public async UnaryResult<bool> KeyDeleteAsync(string key)
        {
            throw new NotImplementedException();
        }

        public async UnaryResult<bool> KeyExistsAsync(string key)
        {
            throw new NotImplementedException();
        }

        public async UnaryResult<long> StringAppendAsync(string key, string value)
        {
            throw new NotImplementedException();
        }

        public async UnaryResult<double> StringDecrementAsync(string key, double val = 1)
        {
            throw new NotImplementedException();
        }

        public async UnaryResult<string> StringGetAsync(string key)
        {
            throw new NotImplementedException();
        }

        public async UnaryResult<List<string>> StringGetAsync(params string[] keys)
        {
            throw new NotImplementedException();
        }

        public async UnaryResult<T> StringGetAsync<T>(string key)
        {
            throw new NotImplementedException();
        }

        public async UnaryResult<List<T>> StringGetAsync<T>(params string[] keys)
        {
            throw new NotImplementedException();
        }

        public async UnaryResult<long> StringGetLengthAsync(string key)
        {
            throw new NotImplementedException();
        }

        public async UnaryResult<string> StringGetSetAsync(string key, string value)
        {
            throw new NotImplementedException();
        }

        public async UnaryResult<T> StringGetSetAsync<T>(string key, T value)
        {
            throw new NotImplementedException();
        }

        public async UnaryResult<double> StringIncrementAsync(string key, double val = 1)
        {
            throw new NotImplementedException();
        }

        public async UnaryResult<bool> StringSetAsync(string key, string value, TimeSpan? expiry = null)
        {
            throw new NotImplementedException();
        }

        public async UnaryResult<bool> StringSetAsync(Dictionary<string, string> valueList)
        {
            throw new NotImplementedException();
        }

        public async UnaryResult<bool> StringSetAsync<T>(string key, T obj, TimeSpan? expiry = null)
        {
            throw new NotImplementedException();
        }
    }
}
