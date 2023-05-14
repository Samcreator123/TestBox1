using Confluent.Kafka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafkaFormTestBox.KafkaObject
{
    public class KafkaProducer
    {
        private IProducer<string, object> _producer = null;
        private string _topic = "test";
        public KafkaProducer() 
        {
            // 設定檔的建立
            ProducerConfig config = new ProducerConfig();
            // 設定發送到broker的地址，也可以設定多個用逗號(,)分別 ex localhost:9092,127.0.0.1:9093
            config.BootstrapServers = "localhost:9092";

            var builder = new ProducerBuilder<string, object>(config);
            //將資料轉換成 bytes 形式
            builder.SetValueSerializer(new KafkaConverter());

            // 建立一個producer 
            _producer = builder.Build();
        }

        //public void SendMsg(string msg)
        //{ 
                    
        //}
        public void SendTopic(string msg)
        {
            // 設定訊息要去哪個topic與partition、設定訊息的key與value 
            _producer.Produce(_topic,new Message<string, object>() { Key = "Test",Value = msg});
        }
    }
}
