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

namespace TreeViw_Steuerelement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<People> Peoples { get; set; }
        public MainWindow()
        {
            
            
            InitializeComponent();

            var personA = new Person
            {
                Name = "Violet"
            };

            var personB = new Person
            {
                Name = "Yelan"
            };

            var peopleSimp = new People
            {
                Category = "Genshin Simps"
            };
            peopleSimp.Person.Add(personB);

            var peopleMe = new People
            {
                Category = "Me"
            };
            peopleMe.Person.Add(personA);

            
            
            Peoples.Add(peopleMe);
            Peoples.Add(peopleSimp);
            

            DataContext = this;
        }
    }
}