using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MQTTnet;
using MQTTnet.Server;

namespace MQTTnetBroker
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                StartServer();
                while(true){

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static void StartServer()
        {
            var optionsServer = new MqttServerOptionsBuilder()
                                    .WithDefaultEndpoint()
                                    .WithConnectionBacklog(10)
                                    .WithDefaultEndpointPort(1822)
                                    .WithSubscriptionInterceptor(c =>
                                    {
                                        c.AcceptSubscription = true;
                                        LogMessage(c, true);
                                    }).WithApplicationMessageInterceptor(c =>
                                    {
                                        c.AcceptPublish = true;
                                        LogMessage(c);
                                    });

            var mqttServer = new MqttFactory().CreateMqttServer();

            mqttServer.StartAsync(optionsServer.Build());
        }

        private static void LogMessage(MqttSubscriptionInterceptorContext context, bool successful)
        {
            if (context == null)
            {
                return;
            }
            Console.WriteLine("Client subscription: " + context.ClientId);
        }

        private static void LogMessage(MqttApplicationMessageInterceptorContext context)
        {
            if (context == null)
            {
                return;
            }
            var payload = context.ApplicationMessage.Payload == null ? null : Encoding.UTF8.GetString(context.ApplicationMessage.Payload);
            Console.WriteLine("Server received: " + payload + " from " + context.ClientId);
        }
    }
}
