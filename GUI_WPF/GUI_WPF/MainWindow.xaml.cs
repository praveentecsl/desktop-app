using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GUI_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new WelcomePage());


        }

        private void NavigateToHomePage(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new HomePage());
        }

        private void NavigateToTouristsPage(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new TouristsPage());
        }

        private void NavigateToBookingsPage(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new BookingsPage());
        }

        private void NavigateToReportsPage(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ReportsPage());
        }
        private void NavigateToWelcomePage(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Navigate(new WelcomePage());
        }
    }

}