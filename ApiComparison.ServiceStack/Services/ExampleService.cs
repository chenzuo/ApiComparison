using ApiComparison.ServiceStack.Dtos;
using ServiceStack.Common.Web;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;
using System;
using System.IO;
using System.Net;

namespace ApiComparison.ServiceStack.Services
{
    public class ExampleService : Service
    {
         public void Put(AddObjectRequestDto add)
         {
             if (add.Name != null)
             {
                 Response.RedirectToUrl("/objects/" + Guid.NewGuid(), HttpStatusCode.Created);
             }
             else
             {
                 throw new ArgumentException();
             }
         }

        public GetObjectResponseDto Get(GetObjectRequestDto request)
        {
            return new GetObjectResponseDto { Id = request.Id };
        }

        public GetObjectResponseDto Get(GetMissingRequestDto request)
        {
            throw new HttpError(HttpStatusCode.NotFound, "404", "Object not found.");
        }

        public HttpResult Get(GetStreamRequestDto request)
        {
            return new HttpResult(new MemoryStream(), "text/plain");
        }
    }
}