using Microsoft.Extensions.Configuration;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RedisConnectionTest
{
    public class Redis
    {
        private static ConnectionMultiplexer _redis = null;
        private Redis() { }

        public static bool IsConnected { get { return _redis.IsConnected; } }
        public static void Init()
        {
            if (_redis == null)
            {
                ConfigurationOptions options = ConfigurationOptions.Parse(SysAppSetting.Getbuilder().Build().GetValue<string>("CacheConnection:RedisConnection"));
                options.Password = SysAppSetting.Getbuilder().Build().GetValue<string>("CacheConnection:Password");

                _redis = ConnectionMultiplexer.Connect(options);
            }
        }

        public static string GetRedisData(string stock)
        {
            try
            {

                IDatabase redis = _redis.GetDatabase();
                string? value = redis.StringGet(stock);
                if (string.IsNullOrWhiteSpace(value))
                {
                    return "get none";
                }
                return value;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static IEnumerable<string> GetAllKey()
        {
            var temp = _redis.GetServer(_redis.GetEndPoints().First()).Keys();
            StringBuilder stringBuilder= new StringBuilder();   
            foreach (var item in temp)
            {
                yield return stringBuilder.AppendLine($"key:{item} is exist, value is {GetRedisData(item)}").ToString();
            }
        }
    }
}
