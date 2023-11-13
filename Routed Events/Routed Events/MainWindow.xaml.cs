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

namespace Routed_Events
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            MessageBox.Show("Event raised by tunneling");
            e.Handled = (bool)RadioButton1.IsChecked;
        }

        private void MainWindow_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            MessageBox.Show("Event raised by Window");
            e.Handled = (bool)RadioButton3.IsChecked;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            MessageBox.Show("Event raised by TextBox");
            e.Handled = (bool)RadioButton1.IsChecked;
        }

        private void TextBoxBase_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            MessageBox.Show("Event raised by grid");
            e.Handled = (bool)RadioButton2.IsChecked;
        }
    }
}