using System.Threading.Tasks;
using ApiComparison.ServiceStackAsync.Dtos;
using ServiceStack.ServiceHost;

namespace ApiComparison.ServiceStackAsync.Services
{
    public class AsyncService : IService<GetStreamRequestDto>
    {
        public object Execute(GetStreamRequestDto request)
        {
            return Task.Factory.StartNew(async () => { await Task.Delay(100); });
        }
    }
}