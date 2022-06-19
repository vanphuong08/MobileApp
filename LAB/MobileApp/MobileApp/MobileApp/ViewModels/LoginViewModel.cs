using MobileApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MobileApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }

        public Command ToggleIsPasswordCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);

            ToggleIsPasswordCommand = new Command(ToggleIsPassword);
        }

        private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }


        private bool _IsPassword = true;
        public bool IsPassword
        {
            get { return _IsPassword; }
            set { SetProperty(ref _IsPassword, value); }
        }
        private void ToggleIsPassword()
        {
            IsPassword = !IsPassword;
        }
    }
}
