using System;
using System.Web;

namespace ApiComparison.ServiceStackAsync
{
    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            new AppHost().Init();
        }
    }
}