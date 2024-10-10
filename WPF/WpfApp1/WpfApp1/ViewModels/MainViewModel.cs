using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private object _currentViewModel;

        public MainViewModel()
        {
            CurrentViewModel = new SignInViewModel(this);
        }

        public void ShowMainView()
        {
            CurrentViewModel = new SignInSuccessViewModel(this);
        }

        public void ShowSignInView()
        {
            CurrentViewModel = new SignInViewModel(this);
        }
    }
}
