using System.Threading.Tasks;
using Simple.Web;

namespace ApiComparison.SimpleWeb.Controllers
{
    [UriTemplate("/objects/stream")]
    public class GetStreamObject : IGetAsync
    {
        public async Task<Status> Get()
        {
            await Task.Delay(100);

            return Status.OK;
        }
    }
}