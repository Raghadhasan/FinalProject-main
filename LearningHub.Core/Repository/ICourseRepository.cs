﻿using LearningHub.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningHub.Core.Repository
{
    public interface ICourseRepository
    {
        List<TraineeCourses> GetCourseByTraineeSection(int id);
    }
}
