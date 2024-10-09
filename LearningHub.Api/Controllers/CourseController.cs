using LearningHub.Core.DTO;
using LearningHub.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearningHub.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;
        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }
        [HttpGet]
        [Route("GetCourseForTrainee/{id}")]
        public List<TraineeCourses> GetCourseByTraineeSection(int id)
        {
            return _courseService.GetCourseByTraineeSection(id);
        }
    }
}
