using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Views;

namespace WpfApp.ViewModels
{
    public partial class SignInViewModel : ObservableObject
    {
        private MainViewModel _mainViewModel;

        public string Id { get; set; }
        public string Password { get; set; }
        public string LoginMessage { get; set; }

        public IRelayCommand SignInCommand { get; set; }
        public IRelayCommand SignUpCommand { get; set; }

        public SignInViewModel(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
            SignInCommand = new RelayCommand(OnSignIn);
            SignUpCommand = new RelayCommand(OnSignUp);
        }
        private void OnSignIn()
        {
            if(Id == "" && Password == "")
            { 
                LoginMessage = "로그인성공";
                _mainViewModel.CurrentViewModel = new MainViewModel();
            }
            else
            {
                LoginMessage = "틀림";
            }
        }

        private void OnSignUp()
        {
            _mainViewModel.CurrentViewModel = new SignUpViewModel(_mainViewModel);
        }

    }
}
