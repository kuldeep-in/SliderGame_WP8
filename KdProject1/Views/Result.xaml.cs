using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using KdProject1.Model;
using KdProject1.Helper;

namespace KdProject1.Views
{
    public partial class Result : PhoneApplicationPage
    {
        public Result()
        {
            InitializeComponent();
        }

        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButton.OKCancel);
            if (result == MessageBoxResult.OK)
            {
                while (NavigationService.BackStack.Any())
                    NavigationService.RemoveBackEntry();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void Again_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        private void Submit_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            ResultModel model = new ResultModel();
            model.UserName = IsoStore.GetValueOrDefault<string>("UserName", null);
            model.TotalMoves = App.ScoreCount;
            model.DateTime = DateTime.Now;
            if(App.ResultData == null)
                App.ResultData = new List<ResultModel>();
            App.ResultData.Add(model);

            NavigationService.Navigate(new Uri("/Views/Scores.xaml", UriKind.Relative));
        }
    }
}