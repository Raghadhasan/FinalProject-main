using LearningHub.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningHub.Core.Services
{
    public interface ICourseService
    {
        List<TraineeCourses> GetCourseByTraineeSection(int id);

    }
}
