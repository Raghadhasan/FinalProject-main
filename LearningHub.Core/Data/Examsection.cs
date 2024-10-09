using System;
using System.Collections.Generic;

namespace LearningHub.Core.Data
{
    public partial class Examsection
    {
        public decimal Examid { get; set; }
        public decimal? Trainercourse { get; set; }
        public string? ExamLink { get; set; }
        public decimal? Exammark { get; set; }
        public DateTime? Examduration { get; set; }

        public virtual Trainersection? TrainercourseNavigation { get; set; }
    }
}
