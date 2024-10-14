using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WpfApp1.ViewModels
{
    public partial class SignInViewModel : ObservableObject
    {
        private MainViewModel _mainViewModel;
        
        [ObservableProperty]
        private string _id = "";

        [ObservableProperty]
        private string _password = "";

        [ObservableProperty]
        private string _loginMessage = "";


        public IRelayCommand SignInCommand { get; set; }

        public SignInViewModel(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
            SignInCommand = new RelayCommand(OnSignIn);
        }

        // SignInCommand 실행시(로그인 버튼 클릭 시) 메서드 호출
        private void OnSignIn()
        {
            // 임시 아이디, 비밀번호
            string UsertId = "admin";
            string UserPassword = "1234";

            if(Id == UsertId && Password == UserPassword)
            {
                _mainViewModel.ShowMainView();
            }
            else
            {
                LoginMessage = "아이디 또는 비밀번호를 확인하세요.";
                Id = string.Empty;
                Password = string.Empty;
            }
        }
    }
}
