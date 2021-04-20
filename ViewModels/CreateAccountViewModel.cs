using Final_Project_4600___Medical_Care_Management_System.Commands;
using Final_Project_4600___Medical_Care_Management_System.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Final_Project_4600___Medical_Care_Management_System.ViewModels
{
    public class CreateAccountViewModel : ViewModelBase
    {
        public ICommand NavigateLogin { get; }
        public ICommand NavigateCreateAccount2 { get; }

       public CreateAccountViewModel(NavigationStore navigationStore)
        {
            NavigateLogin = new NavigateCommand<LoginViewModel>(navigationStore, () => new LoginViewModel(navigationStore));
            NavigateCreateAccount2 = new NavigateCommand<CreateAccount2ViewModel>(navigationStore, () => new CreateAccount2ViewModel(navigationStore));
        }
    }
}
