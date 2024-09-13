using Students_Affaires.Models;

namespace Students_Affaires.Models
{
    public class StoreDoctor
    {
        public int DoctorID { get; set; }
        public virtual Doctor Doctor { get; set; }
        public int ControlID { get; set; }
        public int AffairID { get; set; }
        public virtual Affair Affair { get; set; }
        public virtual Control Control { get; set; }

    }
}
