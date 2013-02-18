using System.IO;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace ApiComparison.Mvc4
{
    public class JsonNetResult : ActionResult
    {
        public JsonNetResult(object data)
        {
            Data = data;
        }

        public object Data { get; set; }

        public override void ExecuteResult(ControllerContext context)
        {
            var serializer = new JsonSerializer();
            var response = context.HttpContext.Response;

            response.ContentType = "application/json";

            if (Data != null)
            {
                using (var writer = new JsonTextWriter(new StreamWriter(response.OutputStream)))
                {
                    serializer.Serialize(writer, Data);
                }
            }
        }
    }
}