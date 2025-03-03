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
    /// Interaction logic for EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        private Guest _guest;

        public EditWindow(Guest guest)
        {
            InitializeComponent();
            _guest = guest;

            // Pre-fill input fields
            FullNameTextBox.Text = guest.FullName;
            EmailTextBox.Text = guest.Email;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var guestToUpdate = context.Guests.Find(_guest.Id);
                if (guestToUpdate != null)
                {
                    // Update details
                    guestToUpdate.FullName = FullNameTextBox.Text;
                    guestToUpdate.Email = EmailTextBox.Text;

                    context.SaveChanges();
                    MessageBox.Show("Guest updated successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }

            this.DialogResult = true; // Close the window and return success
        }
    }
}
