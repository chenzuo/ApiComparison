using System;
using System.Net;
using ApiComparison.ServiceStackAsync.Dtos;
using ServiceStack.Common.Web;
using ServiceStack.ServiceHost;

namespace ApiComparison.ServiceStackAsync.Services
{
    public class SyncService : IService<GetStreamSyncRequestDto>
    {
        public object Execute(GetStreamSyncRequestDto request)
        {
            var client = new WebClient();
            return new HttpResult(client.DownloadString(new Uri("http://www.sunet.se")),
                                  "text/html");
        }
    }
}