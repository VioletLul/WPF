using System.ComponentModel;
using System.Windows;

namespace ProgressBar_Steuerelement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : INotifyPropertyChanged
    {
        private readonly BackgroundWorker _backgroundWorker = new BackgroundWorker();

        private readonly int _maxRecords = 100;

        private int _workerState;

        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;

            _backgroundWorker.DoWork += (s, e) =>
            {
                for (var i = 0; i < _maxRecords; i++)
                {
                    System.Threading.Thread.Sleep(100);
                    WorkerState = i;
                }
                MessageBox.Show(messageBoxText: "Installation abgeschlossen!");
            };

            _backgroundWorker.RunWorkerAsync();
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

/*
        private void _backgroundWorker_DoWork(object sender)
        {
            throw new NotImplementedException();
        }
*/
    }
}