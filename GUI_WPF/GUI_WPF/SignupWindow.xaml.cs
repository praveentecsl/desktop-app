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
    /// Interaction logic for SignupWindow.xaml
    /// </summary>
    public partial class SignupWindow : Window
    {
        
        public SignupWindow()
        {
            InitializeComponent();
            
        }


        private void CreateAccountButton_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var guest = new Guest
                {
                    FullName = FullNameTextBox.Text,
                    Email = EmailTextBox.Text,
                    Password = PasswordBox.Password // Ideally, hash this password
                };

                context.Guests.Add(guest);
                context.SaveChanges();
                MessageBox.Show("Account Created Successfully!");
                this.Close(); // Close signup window
            }
        }

    }
}
