using Students_Affaires.Models;

namespace Students_Affaires.Models
{
    public class StoreStudent
    {
       
        public int StudentID { get; set; }

        public int ControlID { get; set; }
        public int AffairID { get; set; }
        public virtual Affair Affair { get; set; }
        public virtual Control Control { get; set; }
    }
}
