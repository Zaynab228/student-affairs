using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Students_Affaires.Models;

namespace Students_Affaires.Models
{
    public class Affair
    {
        public int AffairID { get; set; }
        public string AffairName { get; set; }
        public string Email { get; set; }
        public string password { get; set; }
        public int phone { get; set; }
        public string Address { get; set; }

        [Display(Name = "Image")]
        [DefaultValue("default.png")]
        public string ImageAffairl { get; set; }
        public virtual ICollection<StoreDoctor> StoreDoctors { get; set; }
        public virtual ICollection<StoreEngineer> StoreEngineers { get; set; }
        public virtual ICollection<StoreStudent> StoreStudents { get; set; }
        public virtual ICollection<StoreCourse> StoreCourses { get; set; }
    }
}



