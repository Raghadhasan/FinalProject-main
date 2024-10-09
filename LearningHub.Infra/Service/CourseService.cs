using LearningHub.Core.DTO;
using LearningHub.Core.Repository;
using LearningHub.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningHub.Infra.Service
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public List<TraineeCourses> GetCourseByTraineeSection(int id)
        {
            return _courseRepository.GetCourseByTraineeSection(id);
        }
    }
}
