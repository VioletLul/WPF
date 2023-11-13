using System;
using System.ComponentModel;
using System.Windows;

namespace ToolTips
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : INotifyPropertyChanged
    {
        private readonly BackgroundWorker _backgroundWorker = new BackgroundWorker();

        // ReSharper disable once ConvertToConstant.Local
        private readonly int _maxRecords = 100;

        private int _workerState;

        public MainWindow()
        {
            InitializeComponent();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public int WorkerState
        {
            get => _workerState;
            set
            {
                _workerState = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("WorkerState"));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataContext = this;

            _backgroundWorker.DoWork += (s, a) =>
            {
                for (var i = 0; i < _maxRecords; i++)
                {
                    System.Threading.Thread.Sleep(100);
                    WorkerState = i;
                }
                MessageBox.Show(messageBoxText: "Datenmigration abgeschlossen!");
            };
            try
            {
                _backgroundWorker.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProgressBar_ValueChanged(object sender, RoutedEventArgs e)
        {
        }
    }
}