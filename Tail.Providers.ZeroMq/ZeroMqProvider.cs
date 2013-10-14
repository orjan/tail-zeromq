using Tail.Extensibility;
using Tail.Providers.ZeroMq.ViewModels;

namespace Tail.Providers.ZeroMq
{
    public sealed class ZeroMqProvider : TailProviderWithConfiguration<ZeroMqListener, ZeroMqContext, ZeroMqConfigurationViewModel>
    {
        public override string GetDisplayName()
        {
            return "0MQ";
        }

        public override ITailStreamContext CreateContext(ZeroMqConfigurationViewModel configuration)
        {
            return configuration.GetContext();
        }
    }
}