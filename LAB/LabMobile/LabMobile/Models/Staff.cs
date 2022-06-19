using System.ComponentModel.DataAnnotations;
using System;
namespace LabMobile.Models
{
    public class Staff
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
        public string Sex { get; set; }
    }
}
