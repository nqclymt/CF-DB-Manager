using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;
using MagicOnion;
using MagicOnion.Server;
namespace CF_DB_Manager
{
    public class RedisHelperSortd : ServiceBase<IRedisHelperSorted>, IRedisHelperSorted
    {
        public async UnaryResult<bool> KeyDeleteAsync(string key)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<bool> KeyExistsAsync(string key)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<bool> SortedSetAddAsync<T>(string key, T value, double? score = null)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<long> SortedSetAddAsync<T>(string key, List<T> value, double? score = null)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<long> SortedSetCombineIntersectAndStoreAsync(string destination, params string[] keys)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<long> SortedSetCombineUnionAndStoreAsync(string destination, params string[] keys)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<double> SortedSetDecrementAsync<T>(string key, T value, double scores)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<double> SortedSetIncrementAsync<T>(string key, T value, double scores)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<long> SortedSetLengthAsync(string key)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<long> SortedSetLengthByValueAsync<T>(string key, T startValue, T endValue)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<double> SortedSetMaxScoreAsync(string key)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<double> SortedSetMinScoreAsync(string key)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<List<T>> SortedSetRangeByRankAsync<T>(string key, long start = 0, long stop = -1, bool desc = false)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<Dictionary<T, double>> SortedSetRangeByRankWithScoresAsync<T>(string key, long start = 0, long stop = -1, bool desc = false)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<List<T>> SortedSetRangeByScoreAsync<T>(string key, double start = 0, double stop = -1, bool desc = false)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<Dictionary<T, double>> SortedSetRangeByScoreWithScoresAsync<T>(string key, double start = 0, double stop = -1, bool desc = false)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<List<T>> SortedSetRangeByValueAsync<T>(string key, T startValue, T endValue)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<long> SortedSetRemoveAsync<T>(string key, params T[] value)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<long> SortedSetRemoveRangeByRankAsync(string key, long start, long stop)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<long> SortedSetRemoveRangeByScoreAsync(string key, double start, double stop)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<long> SortedSetRemoveRangeByValueAsync<T>(string key, T startValue, T endValue)
        {
            throw new System.NotImplementedException();
        }

        public async UnaryResult<double?> SortedSetScoreAsync<T>(string key, T value)
        {
            throw new System.NotImplementedException();
        }
    }
}
