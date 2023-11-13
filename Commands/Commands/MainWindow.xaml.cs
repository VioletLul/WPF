using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Commands
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, ICommandSource
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Launch_Handler(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Launch invoked!");
        }

        private void LaunchEnabled_Handler(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = (bool)CheckBox1.IsChecked;
        }

        public ICommand Command
        {
            get { throw new NotImplementedException(); }
        }
        public object CommandParameter
        {
            get { throw new NotImplementedException(); }
        }
        public IInputElement CommandTarget
        {
            get { throw new NotImplementedException(); }
        }
    }
}