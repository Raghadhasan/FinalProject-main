using System;
using System.Collections.Generic;

namespace LearningHub.Core.Data
{
    public partial class Materialsection
    {
        public decimal Ms { get; set; }
        public decimal? Trainercourse { get; set; }
        public string? Materialfile { get; set; }

        public virtual Trainersection? TrainercourseNavigation { get; set; }
    }
}
