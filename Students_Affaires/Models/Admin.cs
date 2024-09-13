using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Students_Affaires.Models
{
    public class Admin
    {
        public int AdminID { get; set; }
        public string AdminName { get; set; }
        public string Email { get; set; }
        public string password { get; set; }
        public int phone { get; set; }
        public string Address { get; set; }

        [Display(Name = "Image")]
        [DefaultValue("default.png")]
        public string ImageAdmin { get; set; }
        public virtual ICollection<Affair> Affairs { get; set; }
        public virtual ICollection<Control> Controls { get; set; }

    }
}
