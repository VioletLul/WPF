using System.Windows;
using System.Windows.Input;

namespace VisualStates
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

        private void TbText_MouseEnter(object sender, MouseEventArgs e)
        {
            if (TbText.IsMouseOver)
            {
                VisualStateManager.GoToElementState(TbText, "MouseOver", true);
            }
            else
            {
                VisualStateManager.GoToElementState(TbText, "Normal", true);
            }
        }
    }
}
