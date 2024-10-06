using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Signup.ViewModels
{
    public class SignInViewModel :ViewModelBase
    {
        private string _name;
        private string _password;

        public string Name
        { 
            get { return _name; }
            set 
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public ICommand SignInCommand { get; }
        public ICommand SignUpCommand { get; }

        private readonly MainViewModel _mainViewModel;

        public SignInViewModel(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
            SignInCommand = new RelayCommand(SignIn);
            SignUpCommand = _mainViewModel.SignUpCommand;
        }

        public SignInViewModel()
        {
        }

        private void SignIn()
        {
            // 로그인 로직 처리
            if (Name == "test" && Password == "password") // 임시 로그인 로직
            {
                SignInCommand.Execute(null); // 로그인 성공 시 메인 화면으로 이동
            }
            else
            {
                // 로그인 실패 처리
                MessageBox.Show("로그인 실패. 이름 또는 비밀번호가 잘못되었습니다.");
            }
        }
    }
}
