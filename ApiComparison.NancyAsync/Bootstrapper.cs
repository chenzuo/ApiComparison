using Nancy;
using Nancy.Bootstrapper;
using Nancy.Security;

namespace ApiComparison.NancyAsync
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        protected override void ApplicationStartup(Nancy.TinyIoc.TinyIoCContainer container, IPipelines pipelines)
        {
            base.ApplicationStartup(container, pipelines);

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