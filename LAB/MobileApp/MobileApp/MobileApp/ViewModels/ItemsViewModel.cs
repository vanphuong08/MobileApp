using MobileApp.Models;
using MobileApp.Views;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileApp.ViewModels
{
    public class ItemsViewModel: BaseViewModel
    {
        private ObservableCollection<Staff> staffs;
        public ObservableCollection<Staff> Staffs
        {
            get { return staffs; }
            set { SetProperty(ref staffs, value); }
        }
        public ItemsViewModel()
        {
            var listView = new ListView();
            listView.ItemsSource = new string[]
            {
              "mono",
              "monodroid",
              "monotouch",
              "monorail",
              "monodevelop",
              "monotone",
              "monopoly",
              "monomodal",
              "mononucleosis"
             };
        }
    }
}