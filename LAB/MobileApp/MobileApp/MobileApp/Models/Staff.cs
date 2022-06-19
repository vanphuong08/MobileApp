using System;
using System.Collections.Generic;
using System.Text;

namespace MobileApp.Models
{
    public class Staff
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
        public string Sex { get; set; }
        public string ImageIcon { get; set; }
        public DateTime TimeCreate { get; set; }
    }
}
