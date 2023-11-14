using System;
using System.Windows;

namespace ValidationsOnExceptions
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string _message;
        public string Message
        {
            get
            {
                return _message;
            }
            set
            {
                if (value == string.Empty)
                    throw new ArgumentException();
                else
                    _message = value;
            }
        }

        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;
        }
    }
}
