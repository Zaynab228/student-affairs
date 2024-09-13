using MessagePack;
using Students_Affaires.Models;

namespace Students_Affaires.Models
{
    public class Give
    {
        public int DoctorID { get; set; }
        public virtual Doctor Doctor { get; set; }
        public int CourseID { get; set; }
        public virtual Course Course { get; set; }
        
    }
}
