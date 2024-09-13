using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using MessagePack;

namespace Students_Affaires.Models
{
    public class TeachesStudent2
    {
        public int EngineerID { get; set; }
        public int StudentID { get; set; }
        public virtual Engineer Engineer { get; set; }
        public virtual Student Student { get; set; }
    }
}
