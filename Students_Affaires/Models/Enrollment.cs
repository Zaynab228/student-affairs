using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Students_Affaires.Models
{
    public class Enrollment
    {
        public int StudentID { get; set; }
        public int CourseID { get; set; }

        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
    }
}
