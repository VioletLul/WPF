using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace PasswordBox_Element
{
    public class PasswordCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public string Password { get; set; }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            PasswordBox password = (PasswordBox)parameter;
            Password = password.Password;
        }
    }
}