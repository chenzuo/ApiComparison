using System;
using System.IO;
using System.Web.Mvc;
using ApiComparison.Mvc4.Dtos;

namespace ApiComparison.Mvc4.Controllers
{
    public class ExampleController : Controller
    {
        [HttpPut]
        public ActionResult CreateObjectAndRedirect(AddObjectRequestDto add)
        {
            if (add.Name != null)
            {
                return new RedirectWithStatusCodeResult("/objects/" + Guid.NewGuid(), 201);
            }
            else
            {
                return new HttpStatusCodeResult(400);
            }
        }

        [HttpGet]
        public ActionResult GetObject(Guid id)
        {
            return new JsonNetResult(
                new GetObjectResponseDto
                    {
                        Id = id
                    });
        }

        [HttpGet]
        public ActionResult GetNonExistingObject()
        {
            return new HttpStatusCodeResult(404);
        }

        [HttpGet]
        public ActionResult GetStreamWithContentType()
        {
            return new FileStreamResult(new MemoryStream(), "text/plain");
        }
    }
}