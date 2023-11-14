using System.Collections.Generic;
using System.Windows;

namespace Konvertierung
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Person> Persons { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Persons = new List<Person>();

            Person personA = new Person();
            personA.Sex = "Mrs";
            personA.Name = "Yelan";

            Person personB = new Person();
            personB.Sex = "Mr";
            personB.Name = "Violet";

            Persons.Add(personA);
            Persons.Add(personB);

            DataContext = this;
        }
    }
}
