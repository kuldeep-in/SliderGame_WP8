using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using KdProject1.ViewModel;
using System.Collections.ObjectModel;
using KdProject1.Model;

namespace KdProject1.Views
{
    public partial class Scores : PhoneApplicationPage
    {
        ScoreViewModel _viewModel;

        public Scores()
        {
            InitializeComponent();
            _viewModel = DataContext as ScoreViewModel;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (App.ResultData != null)
            {
                NoResult.Visibility = Visibility.Collapsed;
                _viewModel.MyResultList = new ObservableCollection<ResultModel>(App.ResultData.OrderBy(x => x.TotalMoves));
            }
            else
            {
                ResultListBox.Visibility = Visibility.Collapsed;
            }
        }

        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            while (NavigationService.BackStack.Any())
                NavigationService.RemoveBackEntry();
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }
    }
}