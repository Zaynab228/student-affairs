using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Students_Affaires.Models;

namespace Students_Affaires.Models
{
    public class Doctor
    {
        public int DoctorID { get; set; }
        public string DoctorName { get; set; }
        public string Email { get; set; }
        public string password { get; set; }
        public int phone { get; set; }
        public string Address { get; set; }

        [Display(Name = "Image")]
        [DefaultValue("default.png")]
        public string ImageDoctor { get; set; }
        public virtual ICollection<Responsible> Responsibles { get; set; }
        public virtual ICollection<TeachesStudent> TeachesStudents { get; set; }
        public virtual List<Give> Gives { get; set; }
        public virtual ICollection<StoreDoctor> StoreDoctors { get; set; }

    }
}
