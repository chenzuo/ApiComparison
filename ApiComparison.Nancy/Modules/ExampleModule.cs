using System;
using System.IO;
using System.Threading.Tasks;
using ApiComparison.Nancy.Dtos;
using Nancy;
using Nancy.ModelBinding;
using Nancy.Responses;

namespace ApiComparison.Nancy.Modules
{
    public class ExampleModule : NancyModule
    {
        public ExampleModule() : base("/objects")
        {
            Put["/"] = a =>
                {
                    var request = this.Bind<AddObjectRequestDto>();
                    
                    if (request.Name != null)
                    {
                        return Response.AsRedirect("/objects/" + Guid.NewGuid()).WithStatusCode(201);
                    }
                    else
                    {
                        return 400;
                    }
                };

            Get["/{id}"] = a => Response.AsJson(new GetObjectResponseDto { Id = a.id });

            Get["/missing"] = a => 404;

            Get["/stream"] = a => new StreamResponse(() => new MemoryStream(), "text/plain");

            Get["/sync"] = a =>
            {
                Task.Delay(20).Wait();
                return "done";
            };
        }
    }
}