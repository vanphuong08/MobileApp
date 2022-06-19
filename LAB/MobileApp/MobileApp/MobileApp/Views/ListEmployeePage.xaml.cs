using MobileApp.Models;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListEmployeePage : PopupPage
    {
        public ListEmployeePage()
        {
            InitializeComponent();
            List<Staff> myList = new List<Staff>
            {
                new Staff{Name="Lê Văn Phương", Address="Hà Nội", Email="Phuonglv@gmail.com", ImageIcon="imgEmployee.png", PhoneNumber=0123456789, Position="Phó Giám Đốc", Sex="Nam"},
                new Staff{Name="Lê Văn Phương", Address="Hà Nội", Email="Phuonglv@gmail.com", ImageIcon="imgEmployee.png", PhoneNumber=0123456789, Position="Phó Giám Đốc", Sex="Nam"},
                new Staff{Name="Lê Văn Phương", Address="Hà Nội", Email="Phuonglv@gmail.com", ImageIcon="imgEmployee.png", PhoneNumber=0123456789, Position="Phó Giám Đốc", Sex="Nam"},
                new Staff{Name="Lê Văn Phương", Address="Hà Nội", Email="Phuonglv@gmail.com", ImageIcon="imgEmployee.png", PhoneNumber=0123456789, Position="Phó Giám Đốc", Sex="Nam"},
                new Staff{Name="Lê Văn Phương", Address="Hà Nội", Email="Phuonglv@gmail.com", ImageIcon="imgEmployee.png", PhoneNumber=0123456789, Position="Phó Giám Đốc", Sex="Nam"},
                new Staff{Name="Lê Văn Phương", Address="Hà Nội", Email="Phuonglv@gmail.com", ImageIcon="imgEmployee.png", PhoneNumber=0123456789, Position="Phó Giám Đốc", Sex="Nam"},
                new Staff{Name="Lê Văn Phương", Address="Hà Nội", Email="Phuonglv@gmail.com", ImageIcon="imgEmployee.png", PhoneNumber=0123456789, Position="Phó Giám Đốc", Sex="Nam"},
                new Staff{Name="Lê Văn Phương", Address="Hà Nội", Email="Phuonglv@gmail.com", ImageIcon="imgEmployee.png", PhoneNumber=0123456789, Position="Phó Giám Đốc", Sex="Nam"},
                new Staff{Name="Lê Văn Phương", Address="Hà Nội", Email="Phuonglv@gmail.com", ImageIcon="imgEmployee.png", PhoneNumber=0123456789, Position="Phó Giám Đốc", Sex="Nam"},
                new Staff{Name="Lê Văn Phương", Address="Hà Nội", Email="Phuonglv@gmail.com", ImageIcon="imgEmployee.png", PhoneNumber=0123456789, Position="Phó Giám Đốc", Sex="Nam"},
                new Staff{Name="Lê Văn Phương", Address="Hà Nội", Email="Phuonglv@gmail.com", ImageIcon="imgEmployee.png", PhoneNumber=0123456789, Position="Phó Giám Đốc", Sex="Nam"},
                new Staff{Name="Lê Văn Phương", Address="Hà Nội", Email="Phuonglv@gmail.com", ImageIcon="imgEmployee.png", PhoneNumber=0123456789, Position="Phó Giám Đốc", Sex="Nam"},
                new Staff{Name="Lê Văn Phương", Address="Hà Nội", Email="Phuonglv@gmail.com", ImageIcon="imgEmployee.png", PhoneNumber=0123456789, Position="Phó Giám Đốc", Sex="Nam"},
                new Staff{Name="Lê Văn Phương", Address="Hà Nội", Email="Phuonglv@gmail.com", ImageIcon="imgEmployee.png", PhoneNumber=0123456789, Position="Phó Giám Đốc", Sex="Nam"}
            };
            MyListEmployee.ItemsSource = myList;
        }
        async void Click_Delete(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new ItemDetailPage());
        }
        async void Click_Edit(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new ListEmployeePage());
        }
        private async void Click_List(object sender, EventArgs e)
        {
            var page = new ItemDetailPage();

            await PopupNavigation.Instance.PushAsync(page);
        }

    }
}