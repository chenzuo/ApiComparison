using System;
using ServiceStack.ServiceHost;

namespace ApiComparison.ServiceStackAsync.Dtos
{
    [RestService("/objects/{Id}", "GET")]
    public class GetObjectRequestDto
    {
        public Guid Id { get; set; }
    }
}