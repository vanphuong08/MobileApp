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
    public partial class ItemDetailPage : PopupPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            List<Staff> myList = new List<Staff>
            {
                new Staff{Name="Lê Văn Phương", Address="Hà Nội", Email="Phuonglv@gmail.com", ImageIcon="imgEmployee.png", PhoneNumber=0123456789, Position="Phó Giám Đốc", Sex="Nam"}
            };

            ListEmployee.ItemsSource = myList;
        }

        private async void OnClose(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PopAsync();
        }
        private async void OnOpenListViewPage(object sender, EventArgs e)
        {
            var page = new ItemDetailPage();

            await PopupNavigation.Instance.PushAsync(page);
        }
    }
}