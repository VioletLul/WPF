using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Grundelemente
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

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            btn1.Background = Brushes.CadetBlue;
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            btn2.Background = Brushes.Crimson;
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            btn1.Background = Brushes.Aquamarine;
            btn2.Background = Brushes.PowderBlue;
            MessageBox.Show(messageBoxText: "Reset succesfully~");
        }
    }
}