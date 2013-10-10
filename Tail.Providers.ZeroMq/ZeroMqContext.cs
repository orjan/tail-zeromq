using Tail.Extensibility;

namespace Tail.Providers.ZeroMq
{
	public sealed class ZeroMqContext : ITailContext
	{
		private readonly string _url;

        public ZeroMqContext(string url)
        {
            _url = url;
        }

        public string Url
		{
			get { return _url; }
		}

		public string GetDescription()
		{
            return Url;
		}
	}
}
