using Funq;
using ServiceStack.Plugins.Tasks;
using ServiceStack.WebHost.Endpoints;

namespace ApiComparison.ServiceStackAsync
{
    public class AppHost : AppHostBase
    {
        public AppHost() : base("Example Service", typeof(AppHost).Assembly)
        {
        }

        public override void Configure(Container container)
        {
            this.LoadPlugin(new TaskSupport());
        }
    }
}