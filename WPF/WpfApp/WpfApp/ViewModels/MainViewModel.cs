using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        private object _currentViewModel;
        public object CurrentViewModel
        {
            get => _currentViewModel;
            set => SetProperty(ref _currentViewModel, value);
        }
        public IRelayCommand ShowSignInViewCommand { get; }
        public IRelayCommand ShowSignUpViewCommand { get; }

        public MainViewModel()
        {
            // 처음 앱을 실행할 때 로그인 화면을 보여줌
            CurrentViewModel = new SignInViewModel(this);

            // 명령 초기화
            ShowSignInViewCommand = new RelayCommand(ShowSignInView);
            ShowSignUpViewCommand = new RelayCommand(ShowSignUpView);
        }

        private void ShowSignInView()
        {
            // 로그인 화면으로 전환
            CurrentViewModel = new SignInViewModel(this);
        }

        private void ShowSignUpView()
        {
            // 회원가입 화면으로 전환
            CurrentViewModel = new SignUpViewModel(this);
        }
    }
}