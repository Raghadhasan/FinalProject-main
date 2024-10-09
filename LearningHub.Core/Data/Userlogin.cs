using System;
using System.Collections.Generic;

namespace LearningHub.Core.Data
{
    public partial class Userlogin
    {
        public decimal Ul { get; set; }
        public string Username { get; set; } = null!;
        public string? Passwordd { get; set; }
        public string? Status { get; set; }
        public decimal? Roleid { get; set; }
        public decimal? Userid { get; set; }

        public virtual Role? Role { get; set; }
        public virtual Userr? User { get; set; }
    }
}
