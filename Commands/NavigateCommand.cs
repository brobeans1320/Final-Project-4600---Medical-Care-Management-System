using Final_Project_4600___Medical_Care_Management_System.Stores;
using Final_Project_4600___Medical_Care_Management_System.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_4600___Medical_Care_Management_System.Commands
{
    public class NavigateCommand<TViewModel> : CommandBase where TViewModel : ViewModelBase
    {
        private readonly NavigationStore navigationStore;
        private readonly Func<TViewModel> createViewModel;

        public NavigateCommand(NavigationStore navigationStore, Func<TViewModel> createViewModel)
        {
            this.navigationStore = navigationStore;
            this.createViewModel = createViewModel;
        }

        public override void Execute(object parameter)
        {
          
            this.navigationStore.CurrentViewModel = createViewModel();
        }
    }
}
