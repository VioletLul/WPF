using System;
using System.Collections.ObjectModel;

namespace DataBinding_an_Collections
{
    public class PersonViewModel
    {
        public DelegateCommand SetDataToCollection { get; }
        public ObservableCollection<Person> Persons { get; }
        public string? PersonName { get; set; }

        public PersonViewModel()
        {
            SetDataToCollection = new DelegateCommand(AddDataToCollection);
            Persons = new ObservableCollection<Person>();

            var personA = new Person
            {
                Name = "Violet"
            };

            var personB = new Person
            {
                Name = "Furina"
            };

            var personC = new Person
            {
                Name = "Yelan"
            };

            Persons.Add(personA);
            Persons.Add(personB);
            Persons.Add(personC);
        }

        private void AddDataToCollection(object sender, EventArgs e)
        {
            var person = new Person { Name = PersonName };
            Persons.Add(person);
        }
    }
}
