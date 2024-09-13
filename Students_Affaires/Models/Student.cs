using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Students_Affaires.Models;

namespace Students_Affaires.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string password { get; set; }
        public int phone { get; set; }
        public string Address { get; set; }
        public int StudentLevel { get; set; }
        public string ImageStudent { get; set; }
        // public int AdminID { get; set; }
        // public virtual Admin Admin { get; set; }
        public virtual ICollection<TeachesStudent> TeachesStudents { get; set; }
        public virtual ICollection<TeachesStudent2> TeachesStudent2s { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
        public virtual ICollection<Grade> Grades { get; set; }
        public virtual ICollection<StoreStudent> StoreStudents { get; set; }
    }
}
