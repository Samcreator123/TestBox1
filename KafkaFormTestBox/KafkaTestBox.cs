using KafkaFormTestBox.KafkaObject;

namespace KafkaFormTestBox
{
    public partial class KafkaTestBox : Form
    {
        private static KafkaConsumer _consumerA = new KafkaConsumer();
        private static KafkaConsumer _consumerB = new KafkaConsumer();
        private KafkaProducer _producer = new KafkaProducer();

        public KafkaTestBox()
        {
            InitializeComponent();
            _consumerA.BindTextBox(ARecieveTB);
            _consumerB.BindTextBox(BRecieveTB);
        }

        private void UserAConnectionBtn_Click(object sender, EventArgs e)
        {
            if (_consumerA.IsOpen)
            {
                _consumerA.StopListening();
            }
            else
            {
                new Thread(() =>
                {
                    _consumerA.StartListening();
                }).Start();
            }
        }

        private void UserBConnectionBtn_Click(object sender, EventArgs e)
        {
            if (_consumerB.IsOpen)
            {
                _consumerB.StopListening();
            }
            else
            {
                new Thread(() =>
                {
                    _consumerB.StartListening();
                }).Start();
            }
        }

        private void SendTopicBtn_Click(object sender, EventArgs e)
        {
            _producer.SendTopic(SendTopicTB.Text.ToString());
            SendTopicTB.Text = "";
        }
    }
}