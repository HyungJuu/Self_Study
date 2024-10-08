using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1.ViewModels
{
    public partial class SignInViewModel : ObservableObject
    {
        private MainViewModel _mainViewModel;

        [ObservableProperty]
        private string _id;

        [ObservableProperty]
        private string _password;

        [ObservableProperty]
        private string _loginMessage;


        public IRelayCommand SignInCommand { get; set; }

        public SignInViewModel(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
            SignInCommand = new RelayCommand(OnSignIn);
        }

        private void OnSignIn()
        {
            // 임의 아이디, 비밀번호
            string UsertId = "admin";
            string UserPassword = "1234";

            if(Id == UsertId && Password == UserPassword)
            {
                _mainViewModel.ShowMainView();
            }
            else
            {
                LoginMessage = "로그인 실패! 아이디 또는 비밀번호를 확인하세요.";
                //MessageBox.Show("로그인 실패!\n아이디 또는 비밀번호를 확인하세요.", "오류", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
