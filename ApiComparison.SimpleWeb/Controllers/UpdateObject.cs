using ApiComparison.SimpleWeb.Dtos;
using Simple.Web;
using Simple.Web.Behaviors;

namespace ApiComparison.SimpleWeb.Controllers
{
    [UriTemplate("/objects/{Id}")]
    public class UpdateObject : IPut, IInput<AddObjectRequestDto>
    {
        public Status Put()
        {
            return Status.OK;
        }

        public AddObjectRequestDto Input { set; private get; }
        public int Id { get; set; }
    }
}