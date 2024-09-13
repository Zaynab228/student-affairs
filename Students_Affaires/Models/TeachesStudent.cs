using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using MessagePack;

namespace Students_Affaires.Models
{
    public class TeachesStudent
    {
        public int DoctorID { get; set; }
        public int StudentID { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual Student Student { get; set; }
    }
}
