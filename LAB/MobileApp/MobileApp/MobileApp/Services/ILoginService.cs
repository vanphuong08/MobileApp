using System;
using System.Collections.Generic;
using System.Text;

namespace MobileApp.Services
{
    public interface ILoginService
    {
        bool login(string Name, string PassWord);
    }
}
