using MessagePack;
using Students_Affaires.Models;
using System.ComponentModel.DataAnnotations;

namespace Students_Affaires.Models
{
    public class StoreCourse
    {

        public int CourseID { get; set; }

        public virtual Course Course { get; set; }
        public int ControlID { get; set; }
        public int AffairID { get; set; }
        public virtual Affair Affair { get; set; }

        public virtual Control Control { get; set; }
    }
}
