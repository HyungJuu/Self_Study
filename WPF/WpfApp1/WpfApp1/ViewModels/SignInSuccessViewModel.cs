using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.ViewModels
{
    public partial class SignInSuccessViewModel : ObservableObject
    {
        public string SuccessMessage { get; } = "로그인에 성공했습니다!";

        public SignInSuccessViewModel()
        {
            
        }
    }
}
