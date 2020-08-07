using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;
using MagicOnion;
using MagicOnion.Server;
namespace CF_DB_Manager
{
    public class RedisHelperHash : ServiceBase<IRedisHelperHash>, IRedisHelperHash
    {
        public async UnaryResult<bool> KeyExistsAsync(string key)
        {
            throw new System.NotImplementedException();
        }
        public  async UnaryResult<bool> KeyDeleteAsync(string key)
        {
            throw new System.NotImplementedException();

        }
        public async UnaryResult<bool> HashExistAsync(string key, string dataKey)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<bool> HashSetAsync<T>(string key, string dataKey, T t)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<bool> HashDeleteAsync(string key, string dataKey)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<long> HashDeleteAsync(string key, params string[] dataKeys)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<T> HashGetAsync<T>(string key, string dataKey)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<double> HashIncrementAsync(string key, string dataKey, double value)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<double> HashDecrementAsync(string key, string dataKey, double value)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<string[]> HashKeysAsync(string key)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<Dictionary<string, T>> HashGetAllAsync<T>(string key)
        {
            throw new System.NotImplementedException();
        }
    }
}
