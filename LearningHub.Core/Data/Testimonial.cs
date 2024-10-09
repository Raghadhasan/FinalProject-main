using System;
using System.Collections.Generic;

namespace LearningHub.Core.Data
{
    public partial class Testimonial
    {
        public decimal Testimonialid { get; set; }
        public string? Testimonialcontent { get; set; }
        public decimal? Submittedby { get; set; }
        public DateTime? Submitteddate { get; set; }
        public decimal? Approvedby { get; set; }
        public DateTime? Approvaldate { get; set; }

        public virtual Userr? ApprovedbyNavigation { get; set; }
        public virtual Userr? SubmittedbyNavigation { get; set; }
    }
}
