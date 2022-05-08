using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using KdProject1.Helper;
using KdProject1.ViewModel;

namespace KdProject1.Views
{
    public partial class Login : PhoneApplicationPage
    {
        private LoginViewModel _viewModel;

        public Login()
        {
            InitializeComponent();
            _viewModel = new LoginViewModel();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (IsoStore.GetValueOrDefault<string>("UserName", null) != null)
                NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        private void Button_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            IsoStore.AddOrUpdateValue("UserName", userTextBox.Text);
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }
    }
}