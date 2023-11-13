using System;
using System.ComponentModel;

namespace Context_Menü_Steuerelement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : INotifyPropertyChanged
    {
        private string _tbText;
        public string TbText
        {
            get { return _tbText; }
            set
            {
                _tbText = value;
                PropertyChanged(this, new PropertyChangedEventArgs("TbText"));
            }
        }
        
        public ClearCommand ClearCommand { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            ClearCommand = new ClearCommand(ClearMethod);

            DataContext = this;
        }

        public void ClearMethod(object sender, EventArgs e)
        {
            TbText = string.Empty;
        }


        public event PropertyChangedEventHandler? PropertyChanged;
    }
}