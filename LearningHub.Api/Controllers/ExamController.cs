using LearningHub.Core.Data;
using LearningHub.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearningHub.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamController : ControllerBase
    {
        private readonly IExamService _examService;
        public ExamController(IExamService examService)
        {
            _examService = examService;
        }

        [HttpPost]
        [Route("CreateExam")]
        public List<Examsection> CreateExam(Examsection examsection)
        {
            return _examService.CreateExam(examsection);
        }

        [HttpGet]
        [Route("GetExamByCourseId")]
        public List<Examsection> GetExamByCourseId(int id)
        {
            return _examService.GetExamByCourseId(id);
        }

    }
}
