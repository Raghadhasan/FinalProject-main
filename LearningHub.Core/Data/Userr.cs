using System;
using System.Collections.Generic;

namespace LearningHub.Core.Data
{
    public partial class Userr
    {
        public Userr()
        {
            Aboutus = new HashSet<Aboutu>();
            Contactus = new HashSet<Contactu>();
            Sectionattendances = new HashSet<Sectionattendance>();
            TestimonialApprovedbyNavigations = new HashSet<Testimonial>();
            TestimonialSubmittedbyNavigations = new HashSet<Testimonial>();
            Traineesections = new HashSet<Traineesection>();
            Trainersections = new HashSet<Trainersection>();
            Userlogins = new HashSet<Userlogin>();
        }

        public decimal Userid { get; set; }
        public string Username { get; set; } = null!;
        public string? Userimage { get; set; }
        public string? Useremail { get; set; }
        public decimal? Roleid { get; set; }

        public virtual Role? Role { get; set; }
        public virtual ICollection<Aboutu> Aboutus { get; set; }
        public virtual ICollection<Contactu> Contactus { get; set; }
        public virtual ICollection<Sectionattendance> Sectionattendances { get; set; }
        public virtual ICollection<Testimonial> TestimonialApprovedbyNavigations { get; set; }
        public virtual ICollection<Testimonial> TestimonialSubmittedbyNavigations { get; set; }
        public virtual ICollection<Traineesection> Traineesections { get; set; }
        public virtual ICollection<Trainersection> Trainersections { get; set; }
        public virtual ICollection<Userlogin> Userlogins { get; set; }
    }
}
