using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LearningHub.Core.Data
{
    public partial class ModelContext : DbContext
    {
        public ModelContext()
        {
        }

        public ModelContext(DbContextOptions<ModelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Aboutu> Aboutus { get; set; } = null!;
        public virtual DbSet<Assignmentsection> Assignmentsections { get; set; } = null!;
        public virtual DbSet<Contactu> Contactus { get; set; } = null!;
        public virtual DbSet<Course> Courses { get; set; } = null!;
        public virtual DbSet<Examsection> Examsections { get; set; } = null!;
        public virtual DbSet<Materialsection> Materialsections { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<Sectionattendance> Sectionattendances { get; set; } = null!;
        public virtual DbSet<Testimonial> Testimonials { get; set; } = null!;
        public virtual DbSet<Traineesection> Traineesections { get; set; } = null!;
        public virtual DbSet<Trainersection> Trainersections { get; set; } = null!;
        public virtual DbSet<Userlogin> Userlogins { get; set; } = null!;
        public virtual DbSet<Userr> Userrs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseOracle("User Id=c##fp;Password=Test321;Data Source=192.168.1.8:1521/xe");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("C##FP")
                .UseCollation("USING_NLS_COMP");

            modelBuilder.Entity<Aboutu>(entity =>
            {
                entity.HasKey(e => e.Aboutid)
                    .HasName("SYS_C008901");

                entity.ToTable("ABOUTUS");

                entity.Property(e => e.Aboutid)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ABOUTID");

                entity.Property(e => e.Content)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("CONTENT");

                entity.Property(e => e.Updatedby)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("UPDATEDBY");

                entity.HasOne(d => d.UpdatedbyNavigation)
                    .WithMany(p => p.Aboutus)
                    .HasForeignKey(d => d.Updatedby)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_ABOUT_US_USER");
            });

            modelBuilder.Entity<Assignmentsection>(entity =>
            {
                entity.HasKey(e => e.Asec)
                    .HasName("SYS_C008895");

                entity.ToTable("ASSIGNMENTSECTION");

                entity.Property(e => e.Asec)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ASEC");

                entity.Property(e => e.Assignmentduration)
                    .HasColumnType("DATE")
                    .HasColumnName("ASSIGNMENTDURATION");

                entity.Property(e => e.Assignmentfile)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ASSIGNMENTFILE");

                entity.Property(e => e.Assignmentmark)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ASSIGNMENTMARK");

                entity.Property(e => e.Trainercourse)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("TRAINERCOURSE");

                entity.HasOne(d => d.TrainercourseNavigation)
                    .WithMany(p => p.Assignmentsections)
                    .HasForeignKey(d => d.Trainercourse)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_TRAINER_COURSE2");
            });

            modelBuilder.Entity<Contactu>(entity =>
            {
                entity.HasKey(e => e.Contactid)
                    .HasName("SYS_C008904");

                entity.ToTable("CONTACTUS");

                entity.Property(e => e.Contactid)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CONTACTID");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PHONE");

                entity.Property(e => e.Updatedby)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("UPDATEDBY");

                entity.HasOne(d => d.UpdatedbyNavigation)
                    .WithMany(p => p.Contactus)
                    .HasForeignKey(d => d.Updatedby)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_CONTACT_US_USER");
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.ToTable("COURSE");

                entity.Property(e => e.Courseid)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("COURSEID");

                entity.Property(e => e.Courseendtime)
                    .HasPrecision(6)
                    .HasColumnName("COURSEENDTIME");

                entity.Property(e => e.Coursemeetinglink)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("COURSEMEETINGLINK");

                entity.Property(e => e.Coursename)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COURSENAME");

                entity.Property(e => e.Coursestarttime)
                    .HasPrecision(6)
                    .HasColumnName("COURSESTARTTIME");
            });

            modelBuilder.Entity<Examsection>(entity =>
            {
                entity.HasKey(e => e.Examid)
                    .HasName("SYS_C008898");

                entity.ToTable("EXAMSECTION");

                entity.Property(e => e.Examid)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("EXAMID");

                entity.Property(e => e.Examduration)
                    .HasColumnType("DATE")
                    .HasColumnName("EXAMDURATION");

                entity.Property(e => e.ExamLink)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EXAMLINK");

                entity.Property(e => e.Exammark)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("EXAMMARK");

                entity.Property(e => e.Trainercourse)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("TRAINERCOURSE");

                entity.HasOne(d => d.TrainercourseNavigation)
                    .WithMany(p => p.Examsections)
                    .HasForeignKey(d => d.Trainercourse)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_EXAM");
            });

            modelBuilder.Entity<Materialsection>(entity =>
            {
                entity.HasKey(e => e.Ms)
                    .HasName("SYS_C008892");

                entity.ToTable("MATERIALSECTION");

                entity.Property(e => e.Ms)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("MS");

                entity.Property(e => e.Materialfile)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("MATERIALFILE");

                entity.Property(e => e.Trainercourse)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("TRAINERCOURSE");

                entity.HasOne(d => d.TrainercourseNavigation)
                    .WithMany(p => p.Materialsections)
                    .HasForeignKey(d => d.Trainercourse)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_TRAINER_COURSE1");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("ROLE");

                entity.Property(e => e.Roleid)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ROLEID");

                entity.Property(e => e.Rolename)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ROLENAME");
            });

            modelBuilder.Entity<Sectionattendance>(entity =>
            {
                entity.HasKey(e => e.Seat)
                    .HasName("SYS_C008883");

                entity.ToTable("SECTIONATTENDANCE");

                entity.Property(e => e.Seat)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SEAT");

                entity.Property(e => e.Attendancedate)
                    .HasColumnType("DATE")
                    .HasColumnName("ATTENDANCEDATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.Property(e => e.Traineeid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("TRAINEEID");

                entity.Property(e => e.Tsid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("TSID");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.Sectionattendances)
                    .HasForeignKey(d => d.Traineeid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ATTENDANCE_TRAINEE");

                entity.HasOne(d => d.Ts)
                    .WithMany(p => p.Sectionattendances)
                    .HasForeignKey(d => d.Tsid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ATTENDANCE_SECTION");
            });

            modelBuilder.Entity<Testimonial>(entity =>
            {
                entity.ToTable("TESTIMONIALS");

                entity.Property(e => e.Testimonialid)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("TESTIMONIALID");

                entity.Property(e => e.Approvaldate)
                    .HasPrecision(6)
                    .HasColumnName("APPROVALDATE");

                entity.Property(e => e.Approvedby)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("APPROVEDBY");

                entity.Property(e => e.Submittedby)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SUBMITTEDBY");

                entity.Property(e => e.Submitteddate)
                    .HasPrecision(6)
                    .HasColumnName("SUBMITTEDDATE")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Testimonialcontent)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("TESTIMONIALCONTENT");

                entity.HasOne(d => d.ApprovedbyNavigation)
                    .WithMany(p => p.TestimonialApprovedbyNavigations)
                    .HasForeignKey(d => d.Approvedby)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_TESTIMONIAL_APPROVED_BY");

                entity.HasOne(d => d.SubmittedbyNavigation)
                    .WithMany(p => p.TestimonialSubmittedbyNavigations)
                    .HasForeignKey(d => d.Submittedby)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_TESTIMONIAL_SUBMITTED_BY");
            });

            modelBuilder.Entity<Traineesection>(entity =>
            {
                entity.HasKey(e => e.Tsid)
                    .HasName("SYS_C008878");

                entity.ToTable("TRAINEESECTION");

                entity.Property(e => e.Tsid)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("TSID");

                entity.Property(e => e.Courseid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("COURSEID");

                entity.Property(e => e.Traineemark)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("TRAINEEMARK");

                entity.Property(e => e.Traineesolution)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TRAINEESOLUTION");

                entity.Property(e => e.Trainerid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("TRAINERID");

                entity.Property(e => e.Userid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("USERID");

                entity.Property(e => e.Assignmentid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ASSIGNMENTID");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Traineesections)
                    .HasForeignKey(d => d.Courseid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_TRAINEE_COURSE");

                entity.HasOne(d => d.Trainer)
                    .WithMany(p => p.Traineesections)
                    .HasForeignKey(d => d.Trainerid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_TRAINER1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Traineesections)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_TRAINEE_ID");

                entity.HasOne(d => d.Assignmentsection)
                    .WithMany(p => p.Traineesections)
                    .HasForeignKey(d => d.Assignmentid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_TRAINEESECTION_ASSIGNMENT");
            });

            modelBuilder.Entity<Trainersection>(entity =>
            {
                entity.HasKey(e => e.Tsid)
                    .HasName("SYS_C008874");

                entity.ToTable("TRAINERSECTION");

                entity.Property(e => e.Tsid)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("TSID");

                entity.Property(e => e.Assignment)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ASSIGNMENT");

                entity.Property(e => e.Courseid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("COURSEID");

                entity.Property(e => e.Exam)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("EXAM");

                entity.Property(e => e.Material)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("MATERIAL");

                entity.Property(e => e.Userid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("USERID");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Trainersections)
                    .HasForeignKey(d => d.Courseid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_TRAINER_COURSE");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Trainersections)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_TRAINER_ID");
            });

            modelBuilder.Entity<Userlogin>(entity =>
            {
                entity.HasKey(e => e.Ul)
                    .HasName("SYS_C008888");

                entity.ToTable("USERLOGIN");

                entity.Property(e => e.Ul)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("UL");

                entity.Property(e => e.Passwordd)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORDD");

                entity.Property(e => e.Roleid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ROLEID");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.Property(e => e.Userid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("USERID");

                entity.Property(e => e.Username)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Userlogins)
                    .HasForeignKey(d => d.Roleid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_ROLE_ID1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Userlogins)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_USER_ID1");
            });

            modelBuilder.Entity<Userr>(entity =>
            {
                entity.HasKey(e => e.Userid)
                    .HasName("SYS_C008870");

                entity.ToTable("USERR");

                entity.HasIndex(e => e.Useremail, "SYS_C008871")
                    .IsUnique();

                entity.Property(e => e.Userid)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("USERID");

                entity.Property(e => e.Roleid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ROLEID");

                entity.Property(e => e.Useremail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USEREMAIL");

                entity.Property(e => e.Userimage)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USERIMAGE");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Userrs)
                    .HasForeignKey(d => d.Roleid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_ROLE_ID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
