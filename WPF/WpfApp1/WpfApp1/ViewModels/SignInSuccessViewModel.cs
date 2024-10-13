using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.ViewModels
{
    public partial class SignInSuccessViewModel : ObservableObject
    {
        private MainViewModel _mainViewModel;

        public string SuccessMessage { get; } = "로그인에 성공했습니다!";

        public IRelayCommand SignOutCommand { get; }

        // 매개변수 : MainViewModel 인스턴스
        public SignInSuccessViewModel(MainViewModel mainViewModel)
        {
            // 전달된 매개변수를 필드에 할당 -> MainViewModel의 메서드,속성에 접근가능
            _mainViewModel = mainViewModel;
            SignOutCommand = new RelayCommand(OnSignOut);
        }

        // SignOutCommand가 실행될때 메서드 호출
        private void OnSignOut()
        {
            _mainViewModel.ShowSignInView();
        }
    }
}
