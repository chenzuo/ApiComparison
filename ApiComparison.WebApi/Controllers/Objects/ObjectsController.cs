using System.IO;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using ApiComparison.WebApi.Dtos;
using MvcCodeRouting.Web.Http;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiComparison.WebApi.Controllers.Objects
{
    [CustomRoute("objects")]
    public class ObjectsController : ApiController
    {
        public dynamic Post([FromBody]AddObjectRequestDto add)
        {
            if (add.Name != null)
            {
                var response = Request.CreateResponse(HttpStatusCode.Created);
                response.Headers.Location = new Uri("/objects/" + Guid.NewGuid(), UriKind.Relative);

                return response;
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        public dynamic Put([FromRoute]Guid id, [FromBody]AddObjectRequestDto update)
        {
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        public dynamic Get([FromRoute]Guid id)
        {
            return new GetObjectResponseDto
            {
                Id = id
            };
        }

        [CustomRoute("io"), System.Web.Http.HttpGet]
        public HttpResponseMessage GetStreamWithContentType()
        {
            var response = Request.CreateResponse();
            var client = new WebClient();

            response.Content = new StringContent(client.DownloadString(new Uri("http://www.sunet.se")));
            response.Content.Headers.ContentType = new MediaTypeWithQualityHeaderValue("text/html");

            return response;
        }

        [CustomRoute("async-io"), System.Web.Http.HttpGet, AsyncTimeout(10000)]
        public async Task GetStreamWithContentTypeAsync()
        {
            await Task.Delay(100);
        }
    }
}