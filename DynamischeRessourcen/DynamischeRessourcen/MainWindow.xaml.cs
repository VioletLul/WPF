using System.Windows;
using System.Windows.Media;

namespace DynamischeRessourcen
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
            Resources["hintergrund"] = new SolidColorBrush(Colors.Blue);
        }
    }
}
