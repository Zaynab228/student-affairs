using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Xml.Linq;
using Students_Affaires.Models;

namespace Students_Affaires.Models
{
    public class Engineer
    {
        public int EngineerID { get; set; }
        public string EngineerName { get; set; }
        public string Email { get; set; }
        public string password { get; set; }
        public int phone { get; set; }
        public string Address { get; set; }

        [Display(Name = "Image")]
        [DefaultValue("default.png")]
        public string ImageEngineer { get; set; }

       // public int AdminID { get; set; }
       // public virtual Admin Admin { get; set; }
        public virtual ICollection<Responsible> Responsibles { get; set; }
        public virtual ICollection<TeachesStudent2> TeachesStudent2s { get; set; }
        public virtual ICollection<GiveCourse> GiveCourses { get; set; }
        public virtual ICollection<StoreEngineer> StoreEngineers { get; set; }

    }
}
