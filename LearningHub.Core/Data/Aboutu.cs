using System;
using System.Collections.Generic;

namespace LearningHub.Core.Data
{
    public partial class Aboutu
    {
        public decimal Aboutid { get; set; }
        public string? Content { get; set; }
        public decimal? Updatedby { get; set; }

        public virtual Userr? UpdatedbyNavigation { get; set; }
    }
}
