using Simple.Web;

namespace ApiComparison.SimpleWeb
{
    public class StaticConfiguration : IStartupTask
    {
        public void Run(IConfiguration configuration, IWebEnvironment environment)
        {
            configuration.PublicFolders.Add("/Static");
        }
    }
}