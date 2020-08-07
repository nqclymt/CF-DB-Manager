using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;
using MagicOnion;
using MagicOnion.Server;
namespace CF_DB_Manager
{
    public class RedisHelperList : ServiceBase<IRedisHelperList>, IRedisHelperList
    {
        public async UnaryResult<bool> KeyDeleteAsync(string key)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<bool> KeyExistsAsync(string key)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<T> ListGetByIndexAsync<T>(string key, long index)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<long> ListInsertAfterAsync<T>(string key, T pivot, T value)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<long> ListInsertBeforeAsync<T>(string key, T pivot, T value)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<T> ListLeftPopAsync<T>(string key)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<long> ListLeftPushAsync<T>(string key, T value)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<long> ListLeftPushAsync<T>(string key, List<T> value)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<long> ListLengthAsync(string key)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<List<T>> ListRangeAsync<T>(string key)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<long> ListRemoveAsync<T>(string key, T value)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<T> ListRightPopAsync<T>(string key)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<T> ListRightPopLeftPushAsync<T>(string key, string destination)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<long> ListRightPushAsync<T>(string key, T value)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<long> ListRightPushAsync<T>(string key, List<T> value)
        {
            throw new System.NotImplementedException();
        }
    }
}
