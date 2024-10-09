using LearningHub.Core.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearningHub.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadAssignmentController : ControllerBase
    {
        [Route("Upload")]
        [HttpPost]
        public Assignmentsection Upload()
        {
            var file = Request.Form.Files[0];
            var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            var fullPath = Path.Combine("Assignments", fileName);
            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            Assignmentsection a = new Assignmentsection();
            a.Assignmentfile = fileName;
            return a;
        }
    }
}
