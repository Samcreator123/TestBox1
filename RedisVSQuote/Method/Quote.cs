using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace RedisVSQuote.Method
{
    public class Quote
    {
        private static string _connectionString = @"http://10.10.56.237:8080/Quote/Stock.jsp";

        public Quote() { }
        public string testReflection()
        { return Type.GetType("RedisVSQuote.Method.Quote").ToString(); }

        public static string GetQuoteData(string stock)
        {
            var client = new HttpClient();
            string path = GetStockPricePath(_connectionString, stock);
            var response = client.GetAsync(path).Result;

            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsStringAsync().Result;
            }
            else
            {
                throw new System.Exception("從Quote站台取價失敗" + response.StatusCode);
            }
        }

        private static string GetStockPricePath(string path, string stocks)
        {
            return $"{path}?stock={stocks}";
            //StringBuilder pathBuilder = new StringBuilder();
            //pathBuilder.Append($"{path}?stock=");
            //foreach (string stock in stocks)
            //{
            //    pathBuilder.Append($"{stock},");
            //}
            //return pathBuilder.ToString().Substring(0, pathBuilder.Length - 1);
        }
    }


}
