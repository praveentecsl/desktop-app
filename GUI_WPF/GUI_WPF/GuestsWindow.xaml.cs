using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GUI_WPF
{
    /// <summary>
    /// Interaction logic for GuestsWindow.xaml
    /// </summary>
    public partial class GuestsWindow : Window
    {
        private AppDbContext _context = new AppDbContext();

        public GuestsWindow()
        {
            InitializeComponent();
            LoadGuests();
        }

        private void LoadGuests()
        {
            GuestsDataGrid.ItemsSource = _context.Guests.ToList();
        }

        private void DeleteGuest_Click(object sender, RoutedEventArgs e)
        {
            if (GuestsDataGrid.SelectedItem is Guest selectedGuest)
            {
                _context.Guests.Remove(selectedGuest);
                _context.SaveChanges();
                LoadGuests(); // Refresh DataGrid
            }
        }

        private void EditGuest_Click(object sender, RoutedEventArgs e)
        {
            if (GuestsDataGrid.SelectedItem is Guest selectedGuest)
            {
                selectedGuest.FullName = "Updated Name"; // Example update
                _context.SaveChanges();
                LoadGuests(); // Refresh DataGrid
            }
        }
    }

}
