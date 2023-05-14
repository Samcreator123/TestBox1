
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using RedisVSQuote.Method;
using RedisVSQuote.Method.DTO;
using ToolBox;

namespace RedisVSQuote
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Console.WriteLine("比較quote、redis的資料，前三筆stockcode為2330、0050、1234");
                //Console.WriteLine("");

                Redis.Init();

                //RedisSymbol symbol1 = XmlSerializer.XmlDeserializer<RedisSymbol>(Method.Redis.GetRedisData("2330"));
                //Console.WriteLine(ToolBox.ObjectExtension.SeeAllPropertyAndValue(symbol1));

                //symbol1 = XmlSerializer.XmlDeserializer<RedisSymbol>(Method.Redis.GetRedisData("0050"));
                //Console.WriteLine(ToolBox.ObjectExtension.SeeAllPropertyAndValue(symbol1));

                //symbol1 = XmlSerializer.XmlDeserializer<RedisSymbol>(Method.Redis.GetRedisData("1234"));
                //Console.WriteLine(ToolBox.ObjectExtension.SeeAllPropertyAndValue(symbol1));


                //QuoteSymbol symbols = XmlSerializer.XmlDeserializer<QuoteSymbol>(Method.Quote.GetQuoteData("2330,0050,1234,052944,041503,078901,731700,072416,03489P,063368,040275,068966,040954,06331P,035214,08012P,057644,729973,035641,72341P"));
                //foreach (var item in symbols.SymbolList)
                //{
                //    Console.WriteLine(ToolBox.ObjectExtension.SeeAllPropertyAndValue(item));

                //}

                //Console.WriteLine("");
                //Console.WriteLine("以上是獲取的資料，前三筆為redis，後三筆為quote");
                //Console.WriteLine("開始 benchmark...");
                //Console.WriteLine("");

                var summary = BenchmarkRunner.Run<RedisVSQuoteTestClass>();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
            finally
            {
                Console.WriteLine("");
                Console.WriteLine("結束...");
                Console.WriteLine("");
                Console.ReadLine();

            }


        }
    }

    [MemoryDiagnoser]
    public class RedisVSQuoteTestClass
    {
        [Params(1000, 10000, 100000)]
        public int Count;


        [Benchmark]
        public void AccessRedis()
        {
            //List<string> stockCodes = new List<string>()
            //    {"2330","0050","1234","052944","041503","078901","731700","072416","03489P","063368","040275","068966","040954","06331P","035214","08012P","057644","729973","035641","72341P" };

            //foreach (var item in stockCodes)
            //{
            //    RedisSymbol symbol = XmlSerializer.XmlDeserializer<RedisSymbol>(Method.Redis.GetRedisData(item));
            //}

            Redis.Init();

            RedisSymbol symbol1 = XmlSerializer.XmlDeserializer<RedisSymbol>(Method.Redis.GetRedisData("2330"));
            RedisSymbol symbol2 = XmlSerializer.XmlDeserializer<RedisSymbol>(Method.Redis.GetRedisData("0050"));
            RedisSymbol symbol3 = XmlSerializer.XmlDeserializer<RedisSymbol>(Method.Redis.GetRedisData("1234"));
            RedisSymbol symbol4 = XmlSerializer.XmlDeserializer<RedisSymbol>(Method.Redis.GetRedisData("052944"));
            RedisSymbol symbol5 = XmlSerializer.XmlDeserializer<RedisSymbol>(Method.Redis.GetRedisData("041503"));
            RedisSymbol symbol6 = XmlSerializer.XmlDeserializer<RedisSymbol>(Method.Redis.GetRedisData("078901"));
            RedisSymbol symbol7 = XmlSerializer.XmlDeserializer<RedisSymbol>(Method.Redis.GetRedisData("731700"));
            RedisSymbol symbol8 = XmlSerializer.XmlDeserializer<RedisSymbol>(Method.Redis.GetRedisData("072416"));
            RedisSymbol symbol9 = XmlSerializer.XmlDeserializer<RedisSymbol>(Method.Redis.GetRedisData("03489P"));
            RedisSymbol symbol10 = XmlSerializer.XmlDeserializer<RedisSymbol>(Method.Redis.GetRedisData("063368"));
            RedisSymbol symbol11 = XmlSerializer.XmlDeserializer<RedisSymbol>(Method.Redis.GetRedisData("040275"));
            RedisSymbol symbol12 = XmlSerializer.XmlDeserializer<RedisSymbol>(Method.Redis.GetRedisData("068966"));
            RedisSymbol symbol13 = XmlSerializer.XmlDeserializer<RedisSymbol>(Method.Redis.GetRedisData("040954"));
            RedisSymbol symbol14 = XmlSerializer.XmlDeserializer<RedisSymbol>(Method.Redis.GetRedisData("06331P"));
            RedisSymbol symbol15 = XmlSerializer.XmlDeserializer<RedisSymbol>(Method.Redis.GetRedisData("035214"));
            RedisSymbol symbol16 = XmlSerializer.XmlDeserializer<RedisSymbol>(Method.Redis.GetRedisData("08012P"));
            RedisSymbol symbol17 = XmlSerializer.XmlDeserializer<RedisSymbol>(Method.Redis.GetRedisData("057644"));
            RedisSymbol symbol18 = XmlSerializer.XmlDeserializer<RedisSymbol>(Method.Redis.GetRedisData("729973"));
            RedisSymbol symbol19 = XmlSerializer.XmlDeserializer<RedisSymbol>(Method.Redis.GetRedisData("035641"));
            RedisSymbol symbol20 = XmlSerializer.XmlDeserializer<RedisSymbol>(Method.Redis.GetRedisData("72341P"));
        }
        [Benchmark]
        public void AccessQuote()
        {
           QuoteSymbol symbols = XmlSerializer.XmlDeserializer<QuoteSymbol>(Method.Quote.GetQuoteData("2330,0050,1234,052944,041503,078901,731700,072416,03489P,063368,040275,068966,040954,06331P,035214,08012P,057644,729973,035641,72341P"));
        }
    }
}