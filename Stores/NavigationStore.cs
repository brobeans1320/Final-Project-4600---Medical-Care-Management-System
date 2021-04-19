using Final_Project_4600___Medical_Care_Management_System.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_4600___Medical_Care_Management_System.Stores
{
    public class NavigationStore
    {
        public event Action CurrentViewModeChanged;
        private ViewModelBase currentViewModel;
        public ViewModelBase CurrentViewModel
        {
            get => this.currentViewModel;

            set
            {
                this.currentViewModel = value;
                OnCurrentViewModelChanged();
            }
        }

        private void OnCurrentViewModelChanged()
        {
            CurrentViewModeChanged?.Invoke();
        }
    }
}
