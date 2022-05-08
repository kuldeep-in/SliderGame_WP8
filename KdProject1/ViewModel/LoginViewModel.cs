using GalaSoft.MvvmLight;
using KdProject1.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace KdProject1.ViewModel
{
    public class LoginViewModel : ViewModelBase
    {
        public void GetUser()
        {
            //if (IsoStore.GetValueOrDefault<string>("UserName", null) != null)
            //    NavigationService.Navigate(new Uri("MainPage.xaml", UriKind.Relative));
        }
    }
}
