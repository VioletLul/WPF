using System.Windows;

namespace ValidationRules
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string Message { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;
        }
    }
}
