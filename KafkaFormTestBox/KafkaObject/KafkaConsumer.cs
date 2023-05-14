using Confluent.Kafka;

namespace KafkaFormTestBox.KafkaObject
{
    public class KafkaConsumer
    {

        private string _topic = "test";
        private IConsumer<string, object>? _comsumer = null;

        private RichTextBox? _textbox = null;

        private string _state = "close";
        public bool IsOpen { get { return _state == "open"; } }

        CancellationTokenSource _cts = new CancellationTokenSource();
        

        public KafkaConsumer()
        {

        }
        
        public void BindTextBox(RichTextBox textBox)
        {
            _textbox = textBox;
        }

        public void StartListening()
        {
            AppendText(_textbox, "開啟");
            
            this.SetConsumer();
            
            _state = "open";

            _cts = new CancellationTokenSource();

            try
            {
                while (_state == "open")
                {
                    Thread.Sleep(100);
                    var result = _comsumer.Consume(_cts.Token);

                    if (_textbox != null)
                    {
                        AppendText(_textbox, result.Message.Value.ToString());

                    }

                    _comsumer.Commit(result);
                }
            }
            catch (OperationCanceledException) 
            {
                _comsumer.Close();
            }
        }
        private void SetConsumer()
        {
            // consumer 的設定檔
            ConsumerConfig config = new ConsumerConfig();
            // consumer 連接的broker位置
            config.BootstrapServers = "localhost:9092";
            //用以區分不同的消費者
            config.GroupId = "group.1";
            // 讀取的偏移量(offset)，偏移量 : 紀錄consumer消費了多少數據，紀錄consumer應該從哪裡開始讀取
            config.AutoOffsetReset = AutoOffsetReset.Latest;
            // 是否自動提交偏移量
            config.EnableAutoCommit = false;

            ConsumerBuilder<string, object> builder = new ConsumerBuilder<string, object>(config);
            // 將bytes形式的資料轉換成json形式
            builder.SetValueDeserializer(new KafkaConverter());
            // 建立一個consumer 與這個consumer 監聽哪個topic與partition
            _comsumer = builder.Build();
            _comsumer.Subscribe(_topic);
        }
        public void StopListening() 
        {
            _state = "close";
            _cts.Cancel();
            AppendText(_textbox, "關閉");
        }
        public void AppendText(RichTextBox textBox,string msg)
        {
            if (textBox.InvokeRequired)
            {
                textBox.Invoke(AppendText,textBox,msg);
            }
            else
            {
                textBox.AppendText(msg + "\r\n");
            }
        }
    }
}
