using MobileApp.Models;
using MobileApp.ViewModels;
using MobileApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp.Views
{
    
    public partial class ItemsPage : ContentPage
    {
        public ItemsPage()
        {
            InitializeComponent();
            List<Staff> myList = new List<Staff>
            {
                new Staff{Name="Thông tin học viên", Address="a", Email="a", ImageIcon="People.png", PhoneNumber=23434, Position="asdf", Sex="asd"},
                new Staff{Name="Đổi mật khẩu", Address="a", Email="a", ImageIcon="password.png", PhoneNumber=23434, Position="asdf", Sex="asd"},
                new Staff{Name="Đánh giá", Address="a", Email="a", ImageIcon="vote.png", PhoneNumber=23434, Position="asdf", Sex="asd"},
                new Staff{Name="Cài đặt", Address="a", Email="a", ImageIcon="setting.png", PhoneNumber=23434, Position="asdf", Sex="asd"},
                new Staff{Name="Phiên bản", Address="a", Email="a", ImageIcon="version.png", PhoneNumber=23434, Position="asdf", Sex="asd"},
                new Staff{Name="Đăng xuất", Address="a", Email="a", ImageIcon="logout.png", PhoneNumber=23434, Position="asdf", Sex="asd"}
            };
            MyListInfo.ItemsSource = myList;
        }
       
    }
}