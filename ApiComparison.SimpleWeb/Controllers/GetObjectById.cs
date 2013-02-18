using System;
using ApiComparison.SimpleWeb.Dtos;
using Simple.Web;
using Simple.Web.Behaviors;

namespace ApiComparison.SimpleWeb.Controllers
{
    [UriTemplate("/objects/{Id}")]
    public class GetObjectById : IGet, IOutput<GetObjectResponseDto>
    {
        public Status Get()
        {
            Output = new GetObjectResponseDto
                {
                    Id = Id
                };
            
            return Status.OK;
        }

        public int Id { get; set; }
        public GetObjectResponseDto Output { get; private set; }
    }
}