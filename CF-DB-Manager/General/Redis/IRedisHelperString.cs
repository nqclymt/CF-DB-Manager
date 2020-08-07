using System;
using System.Collections.Generic;
using System.Text;
using StackExchange.Redis;
using MagicOnion;

namespace CF_DB_Manager
{
    public interface IRedisHelperString:IService<IRedisHelperString>,IRedisHelper
    {
        /// <summary>
        /// 异步方法 保存单个key value
        /// </summary>
        /// <param name="key">Redis Key</param>
        /// <param name="value">保存的值</param>
        /// <param name="expiry">过期时间</param>
        /// <returns></returns>
        UnaryResult<bool> StringSetAsync(string key, string value, TimeSpan? expiry = default(TimeSpan?));
        /// <summary>
        /// 异步方法 添加多个key/value
        /// </summary>
        /// <param name="valueList">key/value集合</param>
        /// <returns></returns>
        UnaryResult<bool> StringSetAsync(Dictionary<string, string> valueList);
        /// <summary>
        /// 异步方法 保存一个对象
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="key">保存的Key名称</param>
        /// <param name="obj">对象实体</param>
        /// <param name="expiry">过期时间</param>
        /// <returns></returns>
        UnaryResult<bool> StringSetAsync<T>(string key, T obj, TimeSpan? expiry = default(TimeSpan?));
        /// <summary>
        /// 异步方法 在原有key的value值之后追加value
        /// </summary>
        /// <param name="key">追加的Key名称</param>
        /// <param name="value">追加的值</param>
        /// <returns></returns>
        UnaryResult<long> StringAppendAsync(string key, string value);
        /// <summary>
        /// 异步方法 获取单个key的值
        /// </summary>
        /// <param name="key">要读取的Key名称</param>
        /// <returns></returns>
        UnaryResult<string> StringGetAsync(string key);
        /// <summary>
        /// 异步方法 获取多个key的value值
        /// </summary>
        /// <param name="keys">要获取值的Key集合</param>
        /// <returns></returns>
        UnaryResult<List<string>> StringGetAsync(params string[] keys);
        /// <summary>
        /// 异步方法 获取单个key的value值
        /// </summary>
        /// <typeparam name="T">返回数据类型</typeparam>
        /// <param name="key">要获取值的Key集合</param>
        /// <returns></returns>
        UnaryResult<T> StringGetAsync<T>(string key);
        /// <summary>
        /// 异步方法 获取多个key的value值
        /// </summary>
        /// <typeparam name="T">返回数据类型</typeparam>
        /// <param name="keys">要获取值的Key集合</param>
        /// <returns></returns>
        UnaryResult<List<T>> StringGetAsync<T>(params string[] keys);
        /// <summary>
        /// 异步方法 获取旧值赋上新值
        /// </summary>
        /// <param name="key">Key名称</param>
        /// <param name="value">新值</param>
        /// <returns></returns>
        UnaryResult<string> StringGetSetAsync(string key, string value);
        /// <summary>
        /// 异步方法 获取旧值赋上新值
        /// </summary>
        /// <typeparam name="T">数据类型</typeparam>
        /// <param name="key">Key名称</param>
        /// <param name="value">新值</param>
        /// <returns></returns>
        UnaryResult<T> StringGetSetAsync<T>(string key, T value);
        /// <summary>
        /// 异步方法 获取值的长度
        /// </summary>
        /// <param name="key">Key名称</param>
        /// <returns></returns>
        UnaryResult<long> StringGetLengthAsync(string key);
        /// <summary>
        /// 异步方法 数字增长val，返回自增后的值
        /// </summary>
        /// <param name="key"></param>
        /// <param name="val">可以为负</param>
        /// <returns>增长后的值</returns>
        UnaryResult<double> StringIncrementAsync(string key, double val = 1);
        /// <summary>
        /// 异步方法 数字减少val，返回自减少的值
        /// </summary>
        /// <param name="key"></param>
        /// <param name="val">可以为负</param>
        /// <returns>减少后的值</returns>
        UnaryResult<double> StringDecrementAsync(string key, double val = 1);
    }
}
