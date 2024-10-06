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
    public class SignUpViewModel : ViewModelBase
    {
        private string _name;
        private string _email;
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

        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
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

        public ICommand SignUpCommand { get; }
        public ICommand SignInCommand { get; }

        private readonly MainViewModel _mainViewModel;

        public SignUpViewModel(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
            SignUpCommand = new RelayCommand(SignUp);
            SignInCommand = SignInCommand;
        }

        private void SignUp()
        {
            // 회원가입 로직 처리 (임시 처리로 바로 로그인 화면으로 이동)
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("모든 정보를 입력해주세요");
            }
            else
            {
                MessageBox.Show("회원가입이 완료되었습니다.");
                SignInCommand.Execute(null);
            }
        }
    }
}