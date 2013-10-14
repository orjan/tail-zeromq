using System;
using System.Text;
using System.Threading;
using Tail.Extensibility;
using ZeroMQ;

namespace Tail.Providers.ZeroMq
{
    public class ZeroMqListener : TailStreamListener<ZeroMqContext>
    {
        public override void Listen(ZeroMqContext context, ITailCallback callback, WaitHandle abortSignal)
        {
            using (var mqContext = ZmqContext.Create())
            {
                using (var reciever = mqContext.CreateSocket(SocketType.SUB))
                {
                    reciever.Connect(context.Url);
                    reciever.SubscribeAll();

                    while (!abortSignal.WaitOne(0))
                    {
                        string receive = reciever.Receive(Encoding.UTF8);
                        callback.Publish(receive + Environment.NewLine);
                    }
                }
            }
        }
    }
}