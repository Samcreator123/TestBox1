using Microsoft.Extensions.Configuration;
using ToolBox;

namespace RedisConnectionTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Redis.Init();

                if (Redis.IsConnected) 
                {
                    Console.WriteLine("連接成功!");
                }


                var redisData = Redis.GetRedisData(SysAppSetting.Getbuilder().Build().GetValue<string>("CacheKey:Stock"));

                Console.WriteLine(redisData);

                var symbol2 =  XmlSerializer.XmlDeserializer<Symbol>(redisData);

                Console.WriteLine(ToolBox.ObjectExtension.SeeAllPropertyAndValue(symbol2));
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("查詢完畢");
                Console.ReadLine();
            }
        }
    }
}