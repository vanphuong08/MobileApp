using MobileApp.ViewModels;
using Newtonsoft.Json;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
       
        public LoginPage()
        {
            InitializeComponent();
            //this.BindingContext = new LoginViewModel();
        }

        //private async void User()
        //{
        //    var httpClient = new HttpClient();
        //    var reponse = await httpClient.GetStringAsync("ttp://10.1.11.100:8081/api/Login");
        //    var User = JsonConvert.DeserializeObject<List<Stack>>(reponse);
        //    //MyLogin.ItemsSource = User;
        //}

        private void Button_Clicked(object sender, EventArgs e)
        {
            //await PopupNavigation.Instance.PushAsync(new ItemDetailPage());
            //await Navigation.PushAsync(new AppShell());
            if(Name.Text=="admin" && Password.Text == "123")
            {
               
            }
            else { }
        }
    }
}