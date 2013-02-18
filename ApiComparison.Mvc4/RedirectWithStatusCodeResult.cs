using System.Web.Mvc;

namespace ApiComparison.Mvc4
{
    public class RedirectWithStatusCodeResult : RedirectResult
    {
        public RedirectWithStatusCodeResult(string url, int statusCode) : base(url)
        {
            StatusCode = statusCode;
        }

        public RedirectWithStatusCodeResult(string url, int statusCode, bool permanent) : base(url, permanent)
        {
            StatusCode = statusCode;
        }

        protected int StatusCode { get; set; }

        public override void ExecuteResult(ControllerContext context)
        {
            base.ExecuteResult(context);

            context.HttpContext.Response.StatusCode = StatusCode;
        }
    }
}