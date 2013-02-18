using System;
using System.Net;
using ApiComparison.SimpleWeb.Dtos;
using Simple.Web;
using Simple.Web.Behaviors;

namespace ApiComparison.SimpleWeb.Controllers
{
    [UriTemplate("/objects")]
    public class AddObject : IPost, IInput<AddObjectRequestDto>, IMayRedirect
    {
        public Status Post()
        {
            if (Input.Name != null)
            {
                Location = "/objects/1";

                return Status.Created;
            }
            else
            {
                return 400;
            }
        }

        public AddObjectRequestDto Input { set; private get; }
        public string Location { get; private set; }
    }
}