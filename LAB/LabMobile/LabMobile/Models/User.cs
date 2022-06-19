using System.ComponentModel.DataAnnotations;

namespace LabMobile.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string PassWord { get; set; }
        public DateTime PasswordChangeTime { get; set; }
    }
}
