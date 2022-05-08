using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using KdProject1.Resources;
using KdProject1.Model;
using System.Threading;
using KdProject1.Helper;

namespace KdProject1
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public string[,] grid = new string[3, 3]{
                {"a","b","c"},
                {"d","e","f"},
                {"g","h","z"},
            };
        public int img1 = 0;
        public int img2 = 0;
        public int img3 = 0;
        public int img4 = 0;
        public int img5 = 0;
        public int img6 = 0;
        public int img7 = 0;
        public int img8 = 0;
        public int img9 = 0;

        public MainPage()
        {
            InitializeComponent();

            grid[0, 0] = "b";
            grid[0, 1] = "e";
            grid[0, 2] = "g";
            grid[1, 0] = "f";
            grid[1, 1] = "d";
            grid[1, 2] = "c";
            grid[2, 0] = "a";
            grid[2, 1] = "h";
            grid[2, 2] = "z";
            App.ScoreCount = 0;

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void a_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (grid[0, 1] == "z")
            {
                System.Windows.Media.ImageSource temp = b.Source;
                b.Source = a.Source;
                a.Source = temp;
                grid[0, 1] = grid[0, 0];
                grid[0, 0] = "z";
                img1 = 9;
                img2 = 1;
                App.ScoreCount++;
            }
            else if (grid[1, 0] == "z")
            {
                System.Windows.Media.ImageSource temp = d.Source;
                d.Source = a.Source;
                a.Source = temp;
                grid[1, 0] = grid[0, 0];
                grid[0, 0] = "z";
                img1 = 9;
                img4 = 1;
                App.ScoreCount++;
            }
            if (CheckComplete())
            {
                ResetGrid();
            }
        }

        private void b_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (grid[0, 0] == "z")
            {
                System.Windows.Media.ImageSource temp = b.Source;
                b.Source = a.Source;
                a.Source = temp;
                grid[0, 0] = grid[0, 1];
                grid[0, 1] = "z";
                img1 = 2;
                img2 = 9;
                App.ScoreCount++;
            }
            else if (grid[0, 2] == "z")
            {
                System.Windows.Media.ImageSource temp = b.Source;
                b.Source = c.Source;
                c.Source = temp;
                grid[0, 2] = grid[0, 1];
                grid[0, 1] = "z";
                img2 = 9;
                img3 = 2;
                App.ScoreCount++;
            }
            else if (grid[1, 1] == "z")
            {
                System.Windows.Media.ImageSource temp = b.Source;
                b.Source = eT.Source;
                eT.Source = temp;
                grid[1, 1] = grid[0, 1];
                grid[0, 1] = "z";
                img5 = 2;
                img2 = 9;
                App.ScoreCount++;
            }
            if (CheckComplete())
            {
                ResetGrid();
            }
        }

        private void c_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (grid[0, 1] == "z")
            {
                System.Windows.Media.ImageSource temp = b.Source;
                b.Source = c.Source;
                c.Source = temp;
                grid[0, 1] = grid[0, 2];
                grid[0, 2] = "z";
                App.ScoreCount++;
            }
            else if (grid[1, 2] == "z")
            {
                System.Windows.Media.ImageSource temp = c.Source;
                c.Source = f.Source;
                f.Source = temp;
                grid[1, 2] = grid[0, 2];
                grid[0, 2] = "z";
                App.ScoreCount++;
            }
            if (CheckComplete())
            {
                ResetGrid();
            }
        }

        private void d_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (grid[0, 0] == "z")
            {
                System.Windows.Media.ImageSource temp = d.Source;
                d.Source = a.Source;
                a.Source = temp;
                grid[0, 0] = grid[1, 0];
                grid[1, 0] = "z";
                App.ScoreCount++;
            }
            else if (grid[2, 0] == "z")
            {
                System.Windows.Media.ImageSource temp = d.Source;
                d.Source = g.Source;
                g.Source = temp;
                grid[2, 0] = grid[1, 0];
                grid[1, 0] = "z";
                App.ScoreCount++;
            }
            else if (grid[1, 1] == "z")
            {
                System.Windows.Media.ImageSource temp = d.Source;
                d.Source = eT.Source;
                eT.Source = temp;
                grid[1, 1] = grid[1, 0];
                grid[1, 0] = "z";
                App.ScoreCount++;
            }
            if (CheckComplete())
            {
                ResetGrid();
            }
        }

        private void e_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (grid[0, 1] == "z")
            {
                System.Windows.Media.ImageSource temp = b.Source;
                b.Source = eT.Source;
                eT.Source = temp;
                grid[0, 1] = grid[1, 1];
                grid[1, 1] = "z";
                App.ScoreCount++;
            }
            else if (grid[1, 0] == "z")
            {
                System.Windows.Media.ImageSource temp = d.Source;
                d.Source = eT.Source;
                eT.Source = temp;
                grid[1, 0] = grid[1, 1];
                grid[1, 1] = "z";
                App.ScoreCount++;
            }
            else if (grid[1, 2] == "z")
            {
                System.Windows.Media.ImageSource temp = f.Source;
                f.Source = eT.Source;
                eT.Source = temp;
                grid[1, 2] = grid[1, 1];
                grid[1, 1] = "z";
                App.ScoreCount++;
            }
            else if (grid[2, 1] == "z")
            {
                System.Windows.Media.ImageSource temp = h.Source;
                h.Source = eT.Source;
                eT.Source = temp;
                grid[2, 1] = grid[1, 1];
                grid[1, 1] = "z";
                App.ScoreCount++;
            }
            if (CheckComplete())
            {
                ResetGrid();
            }
        }

        private void f_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (grid[0, 2] == "z")
            {
                System.Windows.Media.ImageSource temp = c.Source;
                c.Source = f.Source;
                f.Source = temp;
                grid[0, 2] = grid[1, 2];
                grid[1, 2] = "z";
                App.ScoreCount++;
            }
            else if (grid[1, 1] == "z")
            {
                System.Windows.Media.ImageSource temp = f.Source;
                f.Source = eT.Source;
                eT.Source = temp;
                grid[1, 1] = grid[1, 2];
                grid[1, 2] = "z";
                App.ScoreCount++;
            }
            else if (grid[2, 2] == "z")
            {
                System.Windows.Media.ImageSource temp = z.Source;
                z.Source = f.Source;
                f.Source = temp;
                grid[2, 2] = grid[1, 2];
                grid[1, 2] = "z";
                App.ScoreCount++;
            }
            if (CheckComplete())
            {
                ResetGrid();
            }
        }

        private void g_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (grid[1, 0] == "z")
            {
                System.Windows.Media.ImageSource temp = g.Source;
                g.Source = d.Source;
                d.Source = temp;
                grid[1, 0] = grid[2, 0];
                grid[2, 0] = "z";
                App.ScoreCount++;
            }
            else if (grid[2, 1] == "z")
            {
                System.Windows.Media.ImageSource temp = g.Source;
                g.Source = h.Source;
                h.Source = temp;
                grid[2, 1] = grid[2, 0];
                grid[2, 0] = "z";
                App.ScoreCount++;
            }
            if (CheckComplete())
            {
                ResetGrid();
            }
        }

        private void h_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (grid[2, 0] == "z")
            {
                System.Windows.Media.ImageSource temp = h.Source;
                h.Source = g.Source;
                g.Source = temp;
                grid[2, 0] = grid[2, 1];
                grid[2, 1] = "z";
                App.ScoreCount++;
            }
            else if (grid[1, 1] == "z")
            {
                System.Windows.Media.ImageSource temp = h.Source;
                h.Source = eT.Source;
                eT.Source = temp;
                grid[1, 1] = grid[2, 1];
                grid[2, 1] = "z";
                App.ScoreCount++;
            }
            else if (grid[2, 2] == "z")
            {
                System.Windows.Media.ImageSource temp = h.Source;
                h.Source = z.Source;
                z.Source = temp;
                grid[2, 2] = grid[2, 1];
                grid[2, 1] = "z";
                App.ScoreCount++;
            }
            if (CheckComplete())
            {
                ResetGrid();
            }

        }

        private void z_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (grid[2, 1] == "z")
            {
                System.Windows.Media.ImageSource temp = z.Source;
                z.Source = h.Source;
                h.Source = temp;
                grid[2, 1] = grid[2, 2];
                grid[2, 2] = "z";
                App.ScoreCount++;
            }
            else if (grid[1, 2] == "z")
            {
                System.Windows.Media.ImageSource temp = z.Source;
                z.Source = f.Source;
                f.Source = temp;
                grid[1, 2] = grid[2, 2];
                grid[2, 2] = "z";
                App.ScoreCount++;
            }
            if (CheckComplete())
            {
                ResetGrid();
            }
        }

        public bool CheckComplete()
        {
            if (grid[0, 0] == "a" &&
                grid[0, 1] == "b" &&
                grid[0, 2] == "c" &&
                grid[1, 0] == "d" &&
                grid[1, 1] == "e" &&
                grid[1, 2] == "f" &&
                grid[2, 0] == "g" &&
                grid[2, 1] == "h" &&
                grid[2, 2] == "z")
                return true;
            else
                return false;
        }

        public void ResetGrid()
        {
            //Thread.Sleep(2000);
            NavigationService.Navigate(new Uri("/Views/Result.xaml", UriKind.Relative));
        }

        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            while (NavigationService.BackStack.Any())
                NavigationService.RemoveBackEntry();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            nameBlock.Text = IsoStore.GetValueOrDefault<string>("UserName", null);
        }

        private void Scores_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Views/Scores.xaml", UriKind.Relative));
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}