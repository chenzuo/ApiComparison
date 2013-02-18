using ServiceStack.ServiceHost;

namespace ApiComparison.ServiceStack.Dtos
{
    [Route("/objects")]
    public class AddObjectRequestDto
    {
        public string Name { get; set; }
    }
}