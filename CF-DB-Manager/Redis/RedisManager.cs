using System;
using System.Collections.Generic;
using System.Text;
using Cosmos;
using StackExchange.Redis;
namespace CF_DB_Manager
{
    public class RedisManager : ConcurrentSingleton<RedisManager>
    {
        /// <summary>
        /// 连接配置
        /// </summary>
        readonly string ConnectStr = "192.168.0.117:6379,password=123456,DefaultDatabase=0";
        /// <summary>
        /// Redis保存数据时候key的前缀
        /// </summary>
        internal static readonly string RedisKeyPrefix = "RedisSys";
        /// <summary>
        /// Redis对象
        /// </summary>
        public ConnectionMultiplexer Redis { get; private set; }
        /// <summary>
        /// Redis中的DB
        /// </summary>
        public IDatabase RedisDB { get; private set; }
        public void SetUp()
        {
            Redis = ConnectionMultiplexer.Connect(ConnectStr);
            if (Redis != null)
            {
                RedisDB = Redis.GetDatabase();
                Console.WriteLine("Redis Connect Success ! ");
            }
            else
            {
                throw new RedisConnectionException(ConnectionFailureType.UnableToConnect, "Redis Connect Fail");
            }
        }
    }
}
