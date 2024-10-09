using System;
using System.Collections.Generic;

namespace LearningHub.Core.Data
{
    public partial class Contactu
    {
        public decimal Contactid { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public decimal? Updatedby { get; set; }

        public virtual Userr? UpdatedbyNavigation { get; set; }
    }
}
