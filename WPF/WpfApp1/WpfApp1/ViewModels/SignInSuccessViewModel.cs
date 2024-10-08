﻿using CommunityToolkit.Mvvm.ComponentModel;
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


        public SignInSuccessViewModel(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
            SignOutCommand = new RelayCommand(OnSignOut);
        }

        private void OnSignOut()
        {
            _mainViewModel.ShowSignInView();
        }
    }
}
