using System;
using System.Collections.Generic;
using System.IO;
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

namespace RichTextBox_Steuerelement
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

        private void Laden_Click(object sender, RoutedEventArgs e)
        {
            using (FileStream fileStream = new FileStream("Notiz.rtf", FileMode.Open))
            {
                RtbText.Selection.Load(fileStream, DataFormats.Rtf);
            }
        }

        private void Speichern_Click(object sender, RoutedEventArgs e)
        {
            TextRange textRange = new TextRange(RtbText.Document.ContentStart, RtbText.Document.ContentEnd);

            using (FileStream fileStream = new FileStream("Notiz.rtf", FileMode.Create))
            {
                textRange.Save(fileStream, DataFormats.Rtf);
            }
        }
    }
}