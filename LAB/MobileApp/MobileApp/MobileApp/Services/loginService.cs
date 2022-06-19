using MobileApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileApp.Services
{
    public class loginService : ILoginService
    {
        List<User> users = new List<User>();
        public loginService()
        {
            users.Add(new User { Name = "" });
        }

        public bool login(string Name, string PassWord)
        {
            throw new NotImplementedException();
        }
    }
}
