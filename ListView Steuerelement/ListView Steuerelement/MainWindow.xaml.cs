using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace ListView_Steuerelement
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
            personA.Name = "person 1";

            Person personB = new Person();
            personB.Company = "Cenit AG";
            personB.Name = "person 2";

            Person personC = new Person();
            personC.Company = "Cenit AG";
            personC.Name = "person 3";

            Persons.Add(personA);
            Persons.Add(personB);
            Persons.Add(personC);

            DataContext = this;
        }

        public List<Person> Persons { get; set; }
    }
}