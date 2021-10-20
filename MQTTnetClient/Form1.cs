using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MQTTnet;
using MQTTnet.Server;
using MQTTnet.Client.Options;
using MQTTnet.Client.Receiving;
using MQTTnet.Client.Subscribing;
using MQTTnet.Extensions.ManagedClient;
using MQTTnet.Client.Connecting;
using MQTTnet.Client.Disconnecting;

namespace MQTTnetClient
{
    public partial class Form1 : Form
    {
        IManagedMqttClient mqttClient;
        MqttClientOptionsBuilder clientOptions;
        ManagedMqttClientOptions options;
        MqttTopicFilter topicOptions;
        Timer timer;
        public Form1()
        {
            InitializeComponent();
            txtTopic1.Text = "iconnect/counter";
            txtTopic2.Text = "iconnect/statusmachine";
            txtPort.Text = "1822";

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(OnTimerEvent);          
        }

        private void OnTimerEvent(object sender, EventArgs e)
        {
            SendMessage(txtTopic1.Text, txtValue1.Text);
            SendMessage(txtTopic2.Text, txtValue2.Text);
        }  

        private void CreateMQTTClient()
        {
            clientOptions = new MqttClientOptionsBuilder()
                                    .WithClientId(txtID.Text)
                                    .WithTcpServer("192.168.88.19", int.Parse(txtPort.Text));

            options = new ManagedMqttClientOptionsBuilder()
                        .WithAutoReconnectDelay(TimeSpan.FromSeconds(5))
                        .WithClientOptions(clientOptions.Build())
                        .Build();

            

            mqttClient = new MqttFactory().CreateManagedMqttClient();

            mqttClient.ConnectedHandler = new MqttClientConnectedHandlerDelegate(e => { OnConnected(e); });
            mqttClient.DisconnectedHandler = new MqttClientDisconnectedHandlerDelegate(e => { OnDisconnected(e); });
            mqttClient.ConnectingFailedHandler = new ConnectingFailedHandlerDelegate(e => { OnConnectingFailed(e); });
            mqttClient.ApplicationMessageReceivedHandler = new MqttApplicationMessageReceivedHandlerDelegate(e => { ReceivedMessage(e); });

            mqttClient.StartAsync(options).GetAwaiter().GetResult();

        }

        private void ReceivedMessage(MqttApplicationMessageReceivedEventArgs e)
        {
            try
            {
                txtValueReceived.Text = e.ApplicationMessage.Topic + " = " + Encoding.UTF8.GetString(e.ApplicationMessage.Payload);
                Console.WriteLine("### RECEIVED APPLICATION MESSAGE ###");
                Console.WriteLine("+ Topic = " + e.ApplicationMessage.Topic);
                Console.WriteLine("+ Payload = " + Encoding.UTF8.GetString(e.ApplicationMessage.Payload));
                Console.WriteLine("+ QoS = " + e.ApplicationMessage.QualityOfServiceLevel);
                Console.WriteLine("+ Retain = " + e.ApplicationMessage.Retain);
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, ex);
            }
        }

        public async void OnConnected(MqttClientConnectedEventArgs obj)
        {
            Console.WriteLine("Successfully connected.");
            topicOptions = new MqttTopicFilterBuilder()
                                   .WithTopic(txtTopic1.Text)
                                   .WithExactlyOnceQoS()
                                   .Build();
            var topicOptions2 = new MqttTopicFilterBuilder()
                                   .WithTopic(txtTopic2.Text)
                                   .WithExactlyOnceQoS()
                                   .Build();
            await mqttClient.SubscribeAsync(topicOptions, topicOptions2);
        }

        public static void OnConnectingFailed(ManagedProcessFailedEventArgs obj)
        {
            Console.WriteLine("Couldn't connect to broker.");
        }

        public void OnDisconnected(MqttClientDisconnectedEventArgs obj)
        {
            Console.WriteLine("Successfully disconnected.");
        }

        private async void SendMessage(string topic, string messages)
        {
            System.Threading.CancellationToken cancellationToken;
            var message = new MqttApplicationMessageBuilder()
                              .WithTopic(topic)
                              .WithPayload(messages)
                              .WithExactlyOnceQoS()
                              .WithRetainFlag()
                              .Build();
            await mqttClient.PublishAsync(message, cancellationToken);
            Console.WriteLine("Client send message: ");
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            CreateMQTTClient();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            // SendMessage(txtTopic1.Text, txtValue1.Text);
            timer.Start();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPublish2_Click(object sender, EventArgs e)
        {
            // SendMessage(txtTopic2.Text, txtValue2.Text);
            timer.Stop();
        }
    }
}
