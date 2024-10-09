using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningHub.Core.DTO
{
    public class TraineeCourses
    {
        public string coursename { get; set; }

        public string coursemeetinglink { get; set; }
        public DateTime coursestarttime { get; set; }
        public DateTime courseendtime { get; set; }
        public string TrainerName { get; set; }
    }
}
