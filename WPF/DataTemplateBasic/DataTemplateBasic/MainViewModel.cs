using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class MainViewModel : ViewModelBase
    {
        private List<Student> students = default!;

        public MainViewModel()
        {
            Students = Student.Students;
            CurrentViewModel = new TestViewModel();
        }

        public List<Student> Students { get => students; set { students = value; } }
        public ViewModelBase CurrentViewModel { get; set; }
    }
}
