using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;
using MagicOnion;
using MagicOnion.Server;

namespace CF_DB_Manager
{
    public class RedisHelperSet : ServiceBase<IRedisHelperSet>, IRedisHelperSet;
    {
        public async UnaryResult<bool> KeyDeleteAsync(string key)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<bool> KeyExistsAsync(string key)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<bool> SetAddAsync<T>(string key, T value)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<long> SetAddAsync<T>(string key, List<T> value)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<long> SetCombineDifferenceAndStoreAsync(string destination, params string[] keys)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<List<T>> SetCombineDifferenceAsync<T>(params string[] keys)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<long> SetCombineIntersectAndStoreAsync(string destination, params string[] keys)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<List<T>> SetCombineIntersectAsync<T>(params string[] keys)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<long> SetCombineUnionAndStoreAsync(string destination, params string[] keys)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<List<T>> SetCombineUnionAsync<T>(params string[] keys)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<bool> SetContainsAsync<T>(string key, T value)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<long> SetLengthAsync(string key)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<List<T>> SetMembersAsync<T>(string key)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<T> SetPopAsync<T>(string key)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<T> SetRandomMemberAsync<T>(string key)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<long> SetRemoveAsync<T>(string key, params T[] value)
        {
            throw new System.NotImplementedException();
        }
    }
}
