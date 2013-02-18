using Simple.Web;

namespace ApiComparison.SimpleWeb.Controllers
{
    [UriTemplate("/objects/missing")]
    public class GetMissingObject : IGet
    {
        public Status Get()
        {
            return 404;
        }
    }
}