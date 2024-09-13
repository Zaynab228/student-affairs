using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Students_Affaires.Models;

namespace Students_Affaires.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public int level { get; set; }

        //public virtual ICollection<DoctorCourse> DoctorCourses { get; set; }
        public virtual ICollection<GiveCourse> GiveCourses { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
        public virtual ICollection<StoreCourse> StoreCourses { get; set; }
        public virtual ICollection<Grade> Grades { get; set; }
        public virtual List<Give> Gives { get; set; }
    }
}
