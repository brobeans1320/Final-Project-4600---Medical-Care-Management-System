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
    public class CreateAccount2ViewModel : ViewModelBase
    {
        public ICommand NavigateCreateAccount { get; }
        public CreateAccount2ViewModel(NavigationStore navigationStore)
        {
            NavigateCreateAccount = new NavigateCommand<CreateAccountViewModel>(navigationStore, () => new CreateAccountViewModel(navigationStore));
        }
    }
}
