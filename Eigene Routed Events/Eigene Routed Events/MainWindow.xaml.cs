using System.Windows;

namespace Eigene_Routed_Events
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

        private void MySimpleButton_OnTap(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("uwu");
        }

        private void MySimpleButton_OnTap_from_Grid(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("uwu fwom gwid");
            e.Handled = true;
        }

        private void MainWindow_OnTap_from_Window(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("uwu fwom Window");
        }
    }
}