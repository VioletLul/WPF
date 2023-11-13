using System;
using System.Collections.Generic;
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

namespace DataGrid_Steuerelement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Persons = new List<Person>();

            Person personA = new Person();
            personA.Company = "Cenit AG";
            personA.Name = "Jason Rösser";
            personA.Abteilung = "DFS";

            Person personB = new Person();
            personB.Company = "Cenit AG";
            personB.Name = "Marco Scholl";
            personB.Abteilung = "SAP";

            Person personC = new Person();
            personC.Company = "Cenit AG";
            personC.Name = "Leonie Rommel";
            personC.Abteilung = "SAP";

            Persons.Add(personA);
            Persons.Add(personB);
            Persons.Add(personC);

            DataContext = this;
        }

        public List<Person> Persons { get; set; }
    }
}