using OrderManager.ViewModels;
using OrderManager.Views;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace OrderManager
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void OpenMenuBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenMenuBtn.Visibility = Visibility.Collapsed;
            HideMenuBtn.Visibility = Visibility.Visible;
        }

        private void HideMenuBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenMenuBtn.Visibility = Visibility.Visible;
            HideMenuBtn.Visibility = Visibility.Collapsed;
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }
        //private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    UserControl usc = null;
        //    GridMain.Children.Clear();

        //    switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
        //    {
        //        case "ItemOrders":
        //            usc = new OrdersControl();
        //            GridMain.Children.Add(usc);
        //            break;
        //        case "ItemChat":
        //            usc = new ChatControl();
        //            GridMain.Children.Add(usc);
        //            break;
        //        default:
        //            break;
        //    }
        //}
    }
}
