using LearningHub.Core.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearningHub.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadMaterialController : ControllerBase
    {
        [Route("Upload")]
        [HttpPost]
        public Materialsection Upload()
        {
            var file = Request.Form.Files[0];
            var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            var fullPath = Path.Combine("Materials", fileName);
            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            Materialsection m = new Materialsection();
            m.Materialfile = fileName;
            return m;
        }
    }
}
