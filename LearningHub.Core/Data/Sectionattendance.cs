using System;
using System.Collections.Generic;

namespace LearningHub.Core.Data
{
    public partial class Sectionattendance
    {
        public decimal Seat { get; set; }
        public decimal? Tsid { get; set; }
        public decimal? Traineeid { get; set; }
        public DateTime? Attendancedate { get; set; }
        public string? Status { get; set; }

        public virtual Userr? Trainee { get; set; }
        public virtual Trainersection? Ts { get; set; }
    }
}
