using LearningHub.Core.Data;
using LearningHub.Core.DTO;
using LearningHub.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearningHub.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaterialController : ControllerBase
    {
        private readonly IMaterialService _materialService;
        public MaterialController(IMaterialService materialService)
        {
            _materialService = materialService;
        }
        [HttpGet]
        [Route("ViewMaterial")]
        public ViewMaterial GetMaterial(int id)
        {
            return _materialService.GetMaterial(id);
        }
        [Route("uploadMaterial")]
        [HttpPost]
        public Materialsection UploadMaterial()
        {
            var file = Request.Form.Files[0];
            var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            var fullPath = Path.Combine("MaterialFile", fileName);
            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            Materialsection m = new Materialsection();
            m.Materialfile = fileName;
            return m;
        }

        [Route("downloadMaterial/{fileName}")]
        [HttpGet]
        public IActionResult DownloadMaterial(string fileName)
        {
            var fullPath = Path.Combine("MaterialFile", fileName);

            if (!System.IO.File.Exists(fullPath))
            {
                return NotFound(new { Message = "File not found." });
            }

            var fileBytes = System.IO.File.ReadAllBytes(fullPath);

            return File(fileBytes, "application/octet-stream", fileName);
        }
    }
}
