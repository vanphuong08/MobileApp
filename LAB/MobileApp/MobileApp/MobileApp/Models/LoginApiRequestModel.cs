using System;
using System.Collections.Generic;
using System.Text;

namespace MobileApp.Models
{
    public class LoginApiRequestModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PassWord { get; set; }
        public DateTime PasswordChangeTime { get; set; }
    }
}
