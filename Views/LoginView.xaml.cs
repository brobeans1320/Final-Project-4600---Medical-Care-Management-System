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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Final_Project_4600___Medical_Care_Management_System.Commands;
using Final_Project_4600___Medical_Care_Management_System.ViewModels;

namespace Final_Project_4600___Medical_Care_Management_System.Views
{
    /// <summary>
    /// Interaction logic for LoginViewModel.xaml
    /// </summary>
    public partial class LoginViewModel : UserControl
    {
        public LoginViewModel()
        {
            InitializeComponent();
        }

        private void newAccount_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(username.Text))
            {
                MessageBox.Show("Please enter your username.", "Message", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            if (string.IsNullOrEmpty(pass.Password))
            {
                MessageBox.Show("Please enter your password.", "Message", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            EncryptPassword password = new EncryptPassword(pass.Password);
            string encryptedPass = password.encrypt();
        }
    }
}
