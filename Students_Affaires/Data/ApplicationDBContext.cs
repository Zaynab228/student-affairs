using Students_Affaires.Models;
using Microsoft.EntityFrameworkCore;
using Students_Affaires.Models;

namespace Students_Affaires.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        { }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Affair> Affairs { get; set; }
        public DbSet<Control> Controls { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Engineer> Engineers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StoreDoctor> StoreDoctor { get; set; }
        public DbSet<StoreEngineer> StoreEngineer { get; set; }
        public DbSet<StoreCourse> StoreCourse { get; set; }
        public DbSet<StoreStudent> StoreStudent { get; set; }
        public DbSet<Give> Give { get; set; }
        public DbSet<GiveCourse> GiveCourse { get; set; }
        public DbSet<Enrollment> Enrollment { get; set; }
        public DbSet<Responsible> Responsible { get; set; }
        public DbSet<TeachesStudent> TeachesStudent { get; set; }
        public DbSet<TeachesStudent2> TeachesStudent2 { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<GiveCourse>().HasKey(x =>new { x.CourseID, x.EngineerID });
            builder.Entity<Enrollment>().HasKey(x => new { x.CourseID, x.StudentID });
            builder.Entity<Responsible>().HasKey(x => new { x.DoctorID, x.EngineerID });
            builder.Entity<StoreCourse>().HasKey(x => new { x.ControlID, x.CourseID, x.AffairID });
            builder.Entity<StoreDoctor>().HasKey(x => new { x.DoctorID, x.ControlID, x.AffairID });
            builder.Entity<StoreEngineer>().HasKey(x => new { x.ControlID, x.EngineerID, x.AffairID });
            builder.Entity<StoreStudent>().HasKey(x => new { x.ControlID, x.StudentID, x.AffairID });
            builder.Entity<TeachesStudent>().HasKey(x => new { x.DoctorID, x.StudentID });
            builder.Entity<TeachesStudent2>().HasKey(x => new { x.StudentID, x.EngineerID });
            builder.Entity<Give>().HasKey(x => new { x.CourseID, x.DoctorID });
            builder.Entity<Grade>().HasKey(x => new {x.GradeID });
        }

        public DbSet<Students_Affaires.Models.Grade>? Grade { get; set; }



    }
}
