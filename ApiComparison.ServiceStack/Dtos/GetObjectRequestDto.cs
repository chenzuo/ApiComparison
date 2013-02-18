using System;
using ServiceStack.ServiceHost;

namespace ApiComparison.ServiceStack.Dtos
{
    [Route("/objects/{Id}")]
    public class GetObjectRequestDto
    {
        public Guid Id { get; set; }
    }
}