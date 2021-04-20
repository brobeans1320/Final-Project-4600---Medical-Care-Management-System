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
using Final_Project_4600___Medical_Care_Management_System.ViewModels;
using Final_Project_4600___Medical_Care_Management_System.Commands;
using Final_Project_4600___Medical_Care_Management_System.Stores;

namespace Final_Project_4600___Medical_Care_Management_System.Views
{
    /// <summary>
    /// Interaction logic for CreateAccount.xaml
    /// </summary>
    public partial class CreateAccount : UserControl
    {
        public CreateAccount()
        {

            InitializeComponent();
        }



        private void nextpage_Click(object sender, RoutedEventArgs e)
        {
            Patient newPatient = new Patient();
            if(firstName.Text == "" || lastName.Text == "" || userName.Text == "" || pass.Text == "" || dateOfBirth.Text == "" || email.Text == "" || phoneNumber.Text == "")
            {
                MessageBox.Show("Please Fill Out All Fields Before Continuing","Message", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            if(pass.Text != confirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match", "Message", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            else
            {
                newPatient.setDateOfBirth(dateOfBirth.Text);
                newPatient.setFirstName(firstName.Text);
                newPatient.setLastName(lastName.Text);
                EncryptPassword password = new EncryptPassword(pass.Text);
                string encryptedPass = password.encrypt();
                newPatient.setPassword(password.ToString());
                newPatient.setEmail(email.Text);
                newPatient.setPhoneNumber(phoneNumber.Text);
                
            }
        }
    }
}
