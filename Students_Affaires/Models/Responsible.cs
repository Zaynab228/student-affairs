using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Students_Affaires.Models
{
    public class Responsible
    {
   
        public int DoctorID { get; set; }
    
        public int EngineerID { get; set; }
        public virtual Engineer Engineer { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}
