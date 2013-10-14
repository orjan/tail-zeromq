using Tail.Extensibility;

namespace Tail.Providers.ZeroMq
{
    public sealed class ZeroMqContext : ITailStreamContext
    {
        private readonly string url;

        public ZeroMqContext(string url)
        {
            this.url = url;
        }

        public string Url
        {
            get { return url; }
        }

        public string GetDescription()
        {
            return Url;
        }
    }
}