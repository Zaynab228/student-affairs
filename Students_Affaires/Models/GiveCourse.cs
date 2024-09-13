using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace Students_Affaires.Models
{
    public class GiveCourse
    {
        public int CourseID { get; set; }
        public virtual Course Course { get; set; }

        public int EngineerID { get; set; }
        public virtual Engineer Engineer { get; set; }
    }
}
