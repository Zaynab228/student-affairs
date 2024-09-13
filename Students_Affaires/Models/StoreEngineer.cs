using Students_Affaires.Models;

namespace Students_Affaires.Models
{
    public class StoreEngineer
    {
        public int EngineerID { get; set; }
        public virtual Engineer Engineer { get; set; }
        public int ControlID { get; set; }
        public int AffairID { get; set; }
        public virtual Affair Affair { get; set; }
        public virtual Control Control { get; set; }
    }
}
