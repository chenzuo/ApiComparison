using Funq;
using ServiceStack.WebHost.Endpoints;

namespace ApiComparison.ServiceStack
{
    public class AppHost : AppHostBase
    {
        public AppHost() : base("Example Service", typeof(AppHost).Assembly)
        {
        }

        public override void Configure(Container container)
        {
        }
    }
}