using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.ViewModels
{
    public class SignUpViewModel : ObservableObject
    {
        private MainViewModel _mainViewModel;
        public string Name { get; set; }
        public string Id { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public IRelayCommand RegisterCommand { get; set; }
        public IRelayCommand CancelCommand { get; set; }

        public SignUpViewModel(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
            RegisterCommand = new RelayCommand(OnRegister);
            CancelCommand = new RelayCommand(OnCancel);
        }
        private void OnRegister()
        {
            _mainViewModel.CurrentViewModel = new SignInViewModel(_mainViewModel);
        }

        private void OnCancel()
        {
            _mainViewModel.CurrentViewModel = new SignInViewModel(_mainViewModel);
        }

    }
}
