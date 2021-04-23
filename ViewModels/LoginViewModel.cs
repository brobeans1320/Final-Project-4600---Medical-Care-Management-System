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
    public class LoginViewModel : ViewModelBase
    {
        public ICommand NavigateCreateAccount { get; }
        public ICommand NavigatePatientHome { get; }
       

        public LoginViewModel(NavigationStore navigationStore)
        {
            
            NavigateCreateAccount = new NavigateCommand<CreateAccountViewModel>(navigationStore, () => new CreateAccountViewModel(navigationStore));
            NavigatePatientHome = new NavigateCommand<PatientHomeViewModel>(navigationStore, () => new PatientHomeViewModel(navigationStore));
        }
        
        
    }
}
