using Final_Project_4600___Medical_Care_Management_System.Stores;
using Final_Project_4600___Medical_Care_Management_System.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_4600___Medical_Care_Management_System.Commands
{
    public class NavigateHomeCommand : CommandBase
    {
        private readonly NavigationStore navigationStore;

        public NavigateHomeCommand(NavigationStore navigationStore)
        {
            this.navigationStore = navigationStore;
        }

        public override void Execute(object parameter)
        {
            this.navigationStore.CurrentViewModel = new CreateAccountViewModel();
        }
    }
}
