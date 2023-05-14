using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace RedisVSQuote.Method
{
    public class Redis
    {
        private static string _connectionString = @"localhost:6379";
        private static ConnectionMultiplexer _redis = null;

        private Redis() { }

        public static void Init()
        {
            if (_redis == null)
            {
                ConfigurationOptions options = ConfigurationOptions.Parse(_connectionString);
                options.Password ="systex";

                _redis = ConnectionMultiplexer.Connect(options);
            }
        }

        public static string GetRedisData(string stock)
        {
            try
            {
                stock = "1," + stock;
                IDatabase redis = _redis.GetDatabase();
                string? value = redis.StringGet(stock);
                return value;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
