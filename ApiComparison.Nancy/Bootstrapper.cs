using Nancy;
using Nancy.Bootstrapper;

namespace ApiComparison.Nancy
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        protected override NancyInternalConfiguration InternalConfiguration
        {
            get
            {
                return NancyInternalConfiguration.WithOverrides(c =>
                    {
                        c.StatusCodeHandlers.Clear();
                    });
            }
        }
    }
}