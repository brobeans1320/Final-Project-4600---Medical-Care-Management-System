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

namespace Final_Project_4600___Medical_Care_Management_System.Views
{
    /// <summary>
    /// Interaction logic for CreateDoctor.xaml
    /// </summary>
    public partial class CreateDoctor : UserControl
    {
        public CreateDoctor()
        {
            InitializeComponent();
        }

        private void new_doctor_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(newusername.Text))
            {
                MessageBox.Show("Please enter a username", "Message", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            if(string.IsNullOrEmpty(newpassword.Text))
            {
                MessageBox.Show("Please enter a password", "Message", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            if(string.IsNullOrEmpty(confirmpassword.Text) || confirmpassword.Text != newpassword.Text)
            {
                MessageBox.Show("Passwords do not match", "Message", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            if(string.IsNullOrEmpty(firstname.Text) || string.IsNullOrEmpty(lastname.Text))
            {
                MessageBox.Show("Please enter first and last name", "Message", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
