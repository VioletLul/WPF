using System.Windows;

namespace EventSetters
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button 1");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button 2");
        }

        private void EventSetter_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("EventSetter");
        }
    }
}
