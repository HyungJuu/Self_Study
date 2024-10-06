using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTemplateBasic
{
    public class MainViewModel : ViewModelBase
    {
        private List<Student> students= default!;

        public MainViewModel()
        {
            students = Student.Students;
        }

        public List<Student> Students { get => students; set { students = value; } }
    }
}
