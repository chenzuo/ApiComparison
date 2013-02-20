using Nancy;
using Nancy.Bootstrapper;
using Nancy.Security;

namespace ApiComparison.Nancy
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        protected override void ApplicationStartup(global::Nancy.TinyIoc.TinyIoCContainer container, IPipelines pipelines)
        {
            Csrf.Disable(pipelines);
        }

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