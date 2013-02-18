using ServiceStack.ServiceHost;

namespace ApiComparison.ServiceStackAsync.Dtos
{
    [RestService("/objects", "POST")]
    public class AddObjectRequestDto
    {
        public string Name { get; set; }
    }
}