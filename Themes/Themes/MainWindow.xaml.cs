using System;
using System.Windows;

namespace Themes
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
            Application.Current.Resources.MergedDictionaries.Clear();

            ResourceDictionary resourceDictionary = new ResourceDictionary();
            resourceDictionary.Source = new Uri("GlassButton.xaml", UriKind.Relative);

            Application.Current.Resources.MergedDictionaries.Add(resourceDictionary);
        }
    }
}
